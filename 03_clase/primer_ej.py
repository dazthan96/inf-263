import numpy as np
import pandas as pd
import cv2
from cv2 import imshow
#from .src import *
lista = [1,2,3,4,5,6,7,8]
#print(lista)

#for i in range(len(lista)):
#    print(lista[i])
    
lista2=[i for i in range(10,2,-1)]
#print(lista2)

def sume(a,b):
    return a+b

def multi(a,b):
    return sum([a for i in range(b)])

def operacion(f,a,b):
    return f(a,b)

#print(operacion(multi,5,6))

vector = np.array(lista)
#print(lista)
#print(vector)

#print(len(lista))
#print(vector.shape)
archivo_txt ="D:/facultad/inf-263/03_clase/src/"
archivo_img = "D:/facultad/inf-263/03_clase/img/"
matriz = np.array([[1,2,3,4],[5,6,7,8],[1,9,2,7]])
#print(matriz)
#print(len(matriz))
#print(matriz.shape)
df = pd.read_csv(archivo_txt+"misdatos.txt")
print(df)

image1 = cv2.imread(archivo_img+"cuerpo1.bmp")
image2 = cv2.imread(archivo_img+"cuerpo2.bmp")
cuerpo3 = np.zeros((image1.shape[0], image1.shape[1], image1.shape[2]))
for i in range (image1.shape[0]):
    for j in range(image1.shape[1]):
        if (image1[i,j,0]==0):
            cuerpo3[i,j,0]=0
            cuerpo3[i,j,1]=0
            cuerpo3[i,j,2]=0
        else:
            cuerpo3[i,j,0]=255
            cuerpo3[i,j,1]=255
            cuerpo3[i,j,2]=255
        
for i in range (image2.shape[0]):
    for j in range(image2.shape[1]):
        if (image2[i,j,0]==0):
            cuerpo3[i,j,0]=0
            cuerpo3[i,j,1]=0
            cuerpo3[i,j,2]=0
#print(image)
cv2.imshow("ventana", cuerpo3)
cv2.waitKey(0)
cv2.destroyAllWindows()