import pydicom
from pydicom import dcmread
import cv2
import numpy as np
from matplotlib import pyplot as plt 
from PIL import Image
import os.path
import pandas as pd
from os import listdir
from os.path import isfile, join
import warnings
import os
import sys
from PIL import Image, ImageEnhance
import matplotlib.pyplot as plt


def dicom_to_color(ds,sub_folder):
    fn_name = ds.split('/')[-1][:-4]
    imagedata= pydicom.dcmread(ds)
    img = imagedata.pixel_array.astype(float)
    scaled_image = (np.maximum(img, 0) / img.max()) * 255.0
    scaled_image = np.uint8(scaled_image)
    parent_path='Patients/Colored/'
    
    path = os.path.join(parent_path, sub_folder)
    
    if not os.path.exists(path):
        os.makedirs(path)
    plt.imsave((path +'/{}.png').format(fn_name), scaled_image, cmap = 'turbo')
    #final_image = Image.fromarray(scaled_image)
    
def dicom_to_png(ds):
    fn_name = ds.split('/')[-1][:-4]
    imagedata= pydicom.dcmread(ds)
    img = imagedata.pixel_array.astype(float)
    scaled_image = (np.maximum(img, 0) / img.max()) * 255.0
    scaled_image = np.uint8(scaled_image)
    final_image = Image.fromarray(scaled_image)
    parent_path='Patients/Original/'

    if not os.path.exists(parent_path):
        os.makedirs(parent_path)
    
    a = pydicom.dcmread(ds).PatientID
    
    # if we have PatientID, if it is not '' , then create folders with PatientID
    # else create folders with the name of images ignoring the last three characters

    if  a!= '':
        path = os.path.join(parent_path, a)
        if not os.path.exists(path):
            os.makedirs(path)
            final_image.save((path +'/{}.png').format(fn_name))
            dicom_to_color(ds,a)
            os.remove(ds)
            #cv2.imwrite((path +'/{}.png').format(fn_name),final_image)
        else:
            final_image.save((path +'/{}.png').format(fn_name))
            dicom_to_color(ds,a)
            os.remove(ds)
    else:
        sub_folder = fn_name[:-3]
        path = os.path.join(parent_path, sub_folder)
        if not os.path.exists(path):
            os.makedirs(path)
            final_image.save((path +'/{}.png').format(fn_name))
            dicom_to_color(ds,sub_folder)
            os.remove(ds)
            #cv2.imwrite((path +'/{}.png').format(fn_name),final_image)
        else:
            final_image.save((path +'/{}.png').format(fn_name))
            dicom_to_color(ds,sub_folder)
            os.remove(ds)
            #cv2.imwrite((path +'/{}.png').format(fn_name),final_image)
        #plt.imshow(img)
        #plt.show()
        
def all_dicom_convert(path2):
    for filename in os.listdir(path2):
        ds=path2 + filename
        dicom_to_png(ds)
    #os.rmdir(path2)
        

pth = sys.argv[1]
all_dicom_convert(pth + '/dicoms/')

        
