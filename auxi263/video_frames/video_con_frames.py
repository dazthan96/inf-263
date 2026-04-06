import cv2
import os
ruta_video = 'E:/facu/06semestre/inf-263/paravideo/video/'
ruta_frames = 'E:/facu/06semestre/inf-263/paravideo/frames/'
imagenes = os.listdir(ruta_frames)
print(imagenes[:5])
print(len(imagenes))
frame_ej = cv2.imread(ruta_frames+imagenes[0])
alto, ancho,_ = frame_ej.shape
print(f"Ancho: {ancho} - Alto: {alto}")

driver = cv2.VideoWriter_fourcc(*'mp4v')
video_final = cv2.VideoWriter(ruta_video+'historiav2.mp4', driver, 25, (ancho, alto))
texto1=['La','La primavera','La primavera en la que','La primavera en la que te conoci']
texto2=['Una','Una primavera','Una primavera en la que ','Una primavera en la que no estaras']

contador_frames = 0
for imagen in imagenes:
    frame = cv2.imread(os.path.join(ruta_frames, imagen))
    if frame is None:
        continue
    if contador_frames <100:
        indice = contador_frames//25
        if indice >3:
            indice=3
        cv2.putText(frame, texto1[indice], (50,50), cv2.FONT_HERSHEY_SIMPLEX, 1,(255,255,255),2)
    elif 100<= contador_frames <200:
        indice = (contador_frames-100)//25
        if indice>3:
            indice = 3
        cv2.putText(frame, texto2[indice], (50,100), cv2.FONT_HERSHEY_SIMPLEX,1,(255,255,255),2)
    else:
        cv2.putText(frame, texto1[3], (50,50), cv2.FONT_HERSHEY_SIMPLEX,1,(255,255,255),2)
        cv2.putText(frame, texto2[3],(50,100),cv2.FONT_HERSHEY_SIMPLEX,1,(255,255,255),2)
    
    video_final.write(frame)
    contador_frames +=1
video_final.release()
cv2.destroyAllWindows()