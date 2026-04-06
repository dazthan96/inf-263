import cv2
import os
ruta_video = 'E:/facu/06semestre/inf-263/paravideo/video'
ruta_frames = 'E:/facu/06semestre/inf-263/paravideo/frames'
if not os.path.exists(ruta_frames):
    os.makedirs(ruta_frames)

video_ori = cv2.VideoCapture(ruta_video+'/0405.mp4')

contador = 1
while True:
    respuesta, frame = video_ori.read()
    if not respuesta:
        break

    nombre_archivo = os.path.join(ruta_frames, f"frame_{contador:04d}.jpg")
    cv2.imwrite(nombre_archivo, frame)
    contador +=1

video_ori.release()
cv2.destroyAllWindows()
print(f"Se extrayeron {contador-1} imagenes en la carpeta {ruta_frames}")