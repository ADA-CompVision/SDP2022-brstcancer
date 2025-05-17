# Breast Cancer Image Generation Using Wasserstein Generative Adversarial Network with Gradient Penalty (WGAN-GP)

## Overview

This project is an application of Wasserstein Generative Adversarial Network with Gradient Penalty (WGAN-GP) for the generation of synthetic breast cancer images. The motivation comes from the need for large, diverse datasets in medical imaging, where data collection is expensive and often imbalanced. By introducing synthetic data generation, we aim to augment existing datasets and improve downstream tasks such as classification, and segmentation.

The main components for the WGAN-GP system include the followings:

1. **Preprocessing Pipeline** – Responsible for downloading, saving, and preparing medical images (refer to `GAN/med_images_preprocessing.ipynb`)
2. **GAN Training Pipeline** – Trains a deep convolutional GAN with applied gradient penalty to produce realistic breast cancer images (refer to `GAN/gan_tf_brst_cancer_FINAL.ipynb`)

---

## 1. Project Structure

```
GAN/
├── tests/                         # GAN training tests
├── med_images_preprocessing.ipynb # Image preprocessing
├── gan_tf_brst_cancer_FINAL.ipynb # Final GAN model training
```

---

## 2. Image Processing Pipeline (`med_images_preprocessing.ipynb`)

This notebook constitutes the initial step in the image generation process. It prepares the mammography dataset through the following stages:

### 2.1 Conversion to PNG Format

The raw data is sourced from the **CBIS-DDSM dataset** hosted on Kaggle.
To ensure compatibility with the image generation pipeline, the DICOM files are converted into PNG format using the following steps:

* Each DICOM file is read using the `pydicom` library, which extracts both metadata and pixel data.
* The pixel arrays are normalized and converted into image representations.
* These arrays are then transformed into **PIL images** and saved in **PNG format**.

---

## 3. GAN Training Structure (`gan_tf_brst_cancer_FINAL.ipynb`)

This notebook provides the the end-to-end GAN training process using TensorFlow and TPU acceleration.

### 3.1 TPU Setup and Strategy

The notebook uses `tf.distribute.TPUStrategy` for integrating Google TPUs for fast training of large models.

```python
resolver = tf.distribute.cluster_resolver.TPUClusterResolver()
tf.config.experimental_connect_to_cluster(resolver)
tf.tpu.experimental.initialize_tpu_system(resolver)
strategy = tf.distribute.TPUStrategy(resolver)
```

### 3.2 Data Loading

* Images are loaded and decoded from disk.
* TensorFlow's **TfRecords** from `tf.data.Dataset` is used for efficient data loading and batching.
* Data is shuffled and batched for training.

### 3.3 GAN Architecture

#### Generator

* Transposed convolutional layers (`Conv2DTranspose`)
* Batch Normalization and ReLU activations
* Final layer uses `tanh` activation to output normalized images

#### Discriminator

* Standard convolutional layers
* LeakyReLU activations
* Final output is a sigmoid probability (real/fake)

### 3.4 Training Logic

* The training loop is manually implemented with `@tf.function` for speed.
* Both generator and discriminator losses are computed using binary cross-entropy.
* Gradient penalty is applied to the Discriminator loss to improve training stability and reduce mode collapse.
* Optimizers used: Adam with separate learning rates for stability.

### 3.5 Visualization and Logging

* Generated images are saved at regular intervals.
* Visual samples are used to assess the model’s learning progress.
* Checkpoints are saved for both generator and discriminator.

---

## Acknowledgments

This work was conducted as a continuation of the Senior Design Project (SDP2022) at ADA University. We acknowledge the contributions of all team members and faculty advisors who provided guidance throughout the project.
