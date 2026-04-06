import cv2
import numpy as np

img = cv2.imread(filename="E:/facu/06semestre/inf-263/assets/prueba.jpg")
img_gris = cv2.cvtColor(img, cv2.COLOR_BGR2GRAY)
h, w = img_gris.shape
# Creamos una imagen vacía para guardar el resultado
bordes = np.zeros((h, w), dtype=np.uint8)

# Matrices (Kernels)
mx = np.array([[-1, 0, 1], [-1, 0, 1], [-1, 0, 1]])
my = np.array([[-1, -1, -1], [0, 0, 0], [1, 1, 1]])
# Los dos ciclos externos recorren CADA PÍXEL de la imagen original
for i in range(1, h - 1):
    for j in range(1, w - 1):
        bloque_imagen = img_gris[i-1:i+2, j-1:j+2].astype(float)
        # B. Multiplicación "Uno a Uno" y Suma (Gx y Gy)
        # Esto implementa la matemática: sum(Imagen_3x3 * Filtro_3x3)
        gx = np.sum(bloque_imagen * mx)
        gy = np.sum(bloque_imagen * my)
        
        # C. Magnitud del Borde (Pitágoras)
        magnitud = np.sqrt(gx**2 + gy**2)
        
        # D. Guardamos el resultado (limitando el valor máximo a 255)
        if magnitud > 255:
            magnitud = 255
        bordes[i,j] = int(magnitud)
# IMPORTANTE: Para pegar una imagen a color con una de gris, 
# la de gris debe "aparentar" tener 3 canales (RGB)

bordes_invertidos = 255-bordes#esto es para cambiar den borde blanco a negro

bordes_color = cv2.cvtColor(bordes_invertidos, cv2.COLOR_GRAY2BGR)

# Concatenamos horizontalmente (Original | Bordes)
comparativa = np.hstack((img, bordes_color))
cv2.imshow('Resultado comparado', comparativa)
cv2.waitKey(0)
cv2.destroyAllWindows()
