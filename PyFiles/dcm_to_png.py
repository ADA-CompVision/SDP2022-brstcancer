import pydicom
from pydicom import dcmread
import cv2
import numpy as np
from matplotlib import pyplot as plt 
from PIL import Image
import os.path
import sys

def dicom_to_png(ds):
    fn_name = ds.split('/')[-1][:-4]
    imagedata= pydicom.dcmread(ds)
    img = imagedata.pixel_array.astype(float)
    scaled_image = (np.maximum(img, 0) / img.max()) * 255.0
    scaled_image = np.uint8(scaled_image)
    final_image = Image.fromarray(scaled_image)
    parent_path='Patients/'
    sub_folder = fn_name[:-3]
    if not os.path.exists(parent_path):
        os.makedirs(parent_path)
    path = os.path.join(parent_path, sub_folder)

    if not os.path.exists(path):
        os.makedirs(path)
        final_image.save((path +'/{}.png').format(fn_name))
        os.remove(ds)
    else:
        final_image.save((path +'/{}.png').format(fn_name))
        os.remove(ds)
        #cv2.imwrite((path +'/{}.png').format(fn_name),final_image)
    #plt.imshow(img)
    #plt.show()
    
def all_dicom_convert(path2):
    for filename in os.listdir(path2):
        ds=path2 + filename
        dicom_to_png(ds)
    #os.rmdir(path2)
        
#pth = sys.argv[1]
 
#cwd = os.getcwd()
#print(cwd)   
#cwd = os.chdir(cwd)
#print(cwd)
all_dicom_convert('dicoms/')
