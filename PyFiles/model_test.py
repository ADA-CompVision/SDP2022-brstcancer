#print("Python C# Test")

import pickle
import numpy as np
import pandas as pd
import pydicom
import matplotlib.pyplot as plt
import matplotlib
import os, os.path
import pickle # to save objects to a file
import bz2
import sys

import torch
import torch.nn as nn
import torch.nn.functional as F
from torch.utils.data import Dataset, DataLoader



DEBUG = False
IMG_SIZE = 224

from skimage.feature import greycomatrix, greycoprops
from PIL import Image

distances  =  [1,3] # [1,2,3]
directions =  [0, np.pi/4, np.pi/2, 3*np.pi/4, np.pi, 5*np.pi/4, 3*np.pi/2, 7*np.pi/4]

def get_glcm_features(crop_norm):
    crop_norm_255 = (crop_norm*255).astype(np.uint8)
    
    # 2 pixel distance in 8 directions
    GLCM = greycomatrix(crop_norm_255, distances, directions, normed=False) # symmetric=True, 

    glcm_features = np.empty((0),dtype=np.float32)
    
    for i in range(len(distances)):
        GLCM_Energy = greycoprops(GLCM, 'energy')[i]
        glcm_features = np.concatenate((glcm_features,GLCM_Energy))

        GLCM_corr = greycoprops(GLCM, 'correlation')[i]
        glcm_features = np.concatenate((glcm_features,GLCM_corr))

        GLCM_diss = greycoprops(GLCM, 'dissimilarity')[i]/150 # normalize
        glcm_features = np.concatenate((glcm_features,GLCM_diss))

#         GLCM_hom = graycoprops(GLCM, 'homogeneity')[i]
#         glcm_features = np.concatenate((glcm_features,GLCM_hom))

#         GLCM_contr = graycoprops(GLCM, 'contrast')[i]/15000 # normalize
#         glcm_features = np.concatenate((glcm_features,GLCM_contr))

#         GLCM_asm = graycoprops(GLCM, 'ASM')[i]
#         glcm_features = np.concatenate((glcm_features,GLCM_asm))
    
    glcm_features = np.reshape(glcm_features,(1,3*len(distances)*len(directions)))

    return glcm_features

#if DEBUG:
  #   print(get_glcm_features(img).shape)

import torchvision
from torchvision import datasets, models, transforms
from torchvision.models import inception_v3
from torchvision.models.feature_extraction import create_feature_extractor

model = inception_v3(pretrained=False)

return_nodes = {
    'flatten': 'feats'
    }
pretrained_model = create_feature_extractor(model, return_nodes=return_nodes)
pretrained_model.eval()

x = torch.rand(1, 3, 224, 224)
result = pretrained_model(x)
#print(result)
#print(result['feats'].shape)

import cv2



def crop_image(img,th=0):
    mask = img > th
    return img[np.ix_(mask.any(1),mask.any(0))]


def full_feature_extractor(img):
  # Get GLCM features

  glcmf = get_glcm_features(crop_image(img))
  device = 'cuda' if torch.cuda.is_available() else 'cpu'
  glcm_feats = torch.tensor(glcmf).squeeze(0).to(device)


  # 1
  img = cv2.resize(img, (IMG_SIZE, IMG_SIZE))
  img = torch.Tensor(img)
  img = torch.unsqueeze(torch.unsqueeze(img,0).repeat(3,1,1),0)
          
  img_feats = pretrained_model(img)['feats'].squeeze(0)  # to make [1,2048] -> [2048]
  img_feats = torch.nan_to_num(img_feats, nan=0.0)      # also replace all NaN with 0.0
  img_feats = img_feats

  return torch.cat((img_feats, glcm_feats))


# 2048 - Inception
# 48  - GLCM


#fname = 'test.png'
fname1 = sys.argv[1]

img = Image.open(fname1)
img = cv2.imread(fname1,0)

# visualize the image here
#print(img.shape)
#plt.imshow(img,cmap='gray')

img = np.array(img)
#print(img.shape)
#img = np.mean(img,2)
# print(img.shape)
features = full_feature_extractor(img)

#print(features.shape)
#print(features.type)

fs=features.detach().numpy()
#print(fs)
fs = fs.reshape(1,-1)





#filename = 'finalized_model.sav'
filename = sys.argv[5] #2


#print(filename)
#model = pickle.load(open("model.pkl", "rb"))
loaded_model = pickle.load(open(filename, 'rb'))
result = loaded_model.predict(fs)
#print(result)
a = result[0]
b = str(int(a))



fname2 = sys.argv[2]
img = Image.open(fname2)
img = cv2.imread(fname2,0)
img = np.array(img)
features = full_feature_extractor(img)
fs=features.detach().numpy()
fs = fs.reshape(1,-1)
filename = sys.argv[5] #2
#model = pickle.load(open("model.pkl", "rb"))
loaded_model = pickle.load(open(filename, 'rb'))
result = loaded_model.predict(fs)
a = result[0]
b = b + ' ' + str(int(a))

fname3 = sys.argv[3]
img = Image.open(fname3)
img = cv2.imread(fname3,0)
img = np.array(img)
features = full_feature_extractor(img)
fs=features.detach().numpy()
fs = fs.reshape(1,-1)
filename = sys.argv[5] #2
#model = pickle.load(open("model.pkl", "rb"))
loaded_model = pickle.load(open(filename, 'rb'))
result = loaded_model.predict(fs)
a = result[0]
b = b + ' ' + str(int(a))



fname4 = sys.argv[4]
img = Image.open(fname4)
img = cv2.imread(fname4,0)
img = np.array(img)
features = full_feature_extractor(img)
fs=features.detach().numpy()
fs = fs.reshape(1,-1)
filename = sys.argv[5] #2
#model = pickle.load(open("model.pkl", "rb"))
loaded_model = pickle.load(open(filename, 'rb'))
result = loaded_model.predict(fs)
a = result[0]
b = b + ' ' + str(int(a)) + '\n'

print(b)

file1 = open('pred.txt', 'w')
file1.write(b)
file1.close()


#def all_dicom_convert(path2):
 #   for filename in os.listdir(path2):
  #      ds=path2 + filename
   #     dicom_to_png(ds)
    #os.rmdir(path2)
        
#pth = sys.argv[1]
 
#cwd = os.getcwd()
#print(cwd)   
#cwd = os.chdir(cwd)
#print(cwd)
#all_dicom_convert('dicoms/')

