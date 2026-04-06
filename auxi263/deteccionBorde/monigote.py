import cv2
import numpy as np

cabeza = cv2.imread('E:/facu/06semestre/inf-263/assets/cabeza1.png')
cabeza2 = cv2.imread('E:/facu/06semestre/inf-263/assets/cabeza2.png')
payaso = cv2.imread('E:/facu/06semestre/inf-263/assets/payaso.png')
cuerpo = cv2.imread('E:/facu/06semestre/inf-263/assets/cuerpo.png')
brazos = cv2.imread('E:/facu/06semestre/inf-263/assets/brazos.png')

#creamos un fondo blanco para formar reconstruir
fondo = np.full((300,300,3), 255, dtype=np.uint8)
#tomando las dimensiones de las piezas
alto_cabeza, ancho_cabeza, _ = cabeza.shape
alto_cuerpo, ancho_cuerpo, _ = cuerpo.shape
alto_brazos, ancho_brazos,_ = brazos.shape


#formamos el cuerpo y los brazos primero
cuerpo_brazos = cv2.bitwise_and(cuerpo, brazos)
#primer version
monigote_auxiliar1 = cv2.addWeighted(cuerpo_brazos,0.5,cabeza,0.5,0)
monigote_final1 = cv2.cvtColor(monigote_auxiliar1, cv2.COLOR_BGR2GRAY)

#segunda version
monigote_auxiliar2 = cv2.bitwise_and(cuerpo_brazos,cabeza2)
monigote_final2 = cv2.cvtColor(monigote_auxiliar2, cv2.COLOR_BGR2GRAY)

#aca colocaremos una cabeza de payaso no creada en el lienzo
nueva_cabeza_payaso = cv2.resize(payaso, (75,75))
payaso_gris = cv2.cvtColor(nueva_cabeza_payaso, cv2.COLOR_BGR2GRAY)
y_ini, x_ini = 15, 85
y_fin, x_fin = y_ini + 75, x_ini+75

monigote_final3 = monigote_final2.copy()
monigote_final3[y_ini:y_fin, x_ini:x_fin] = payaso_gris

#comparativa = np.hstack((monigote_final1, monigote_final2, nueva_cabeza_payaso))
comparativa = np.hstack(( monigote_final2, monigote_final3))
#cv2.imshow('primer monigote',monigote_final2)

#puedes usar cv2.subtract para ver las diferencia enrte dos imagenes (ene sta caso para la cabeza, puede puedes usarlo para ver que cambio entre las cabezas)
#si existen dos monigotes casi iguales, y en uno moviste el brazo, pones la primer imagen con brazos abajo y la segunda imagen como parametros respectivamente y subtract coloreara en negro lo igual pero coloreara en blanco lo que sea diferente
cv2.imshow('Resultado comparado', comparativa)
cv2.waitKey(0)
cv2.destroyAllWindows()
