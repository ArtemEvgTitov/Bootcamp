import cv2

img = cv2.imread('C:/Users/artem/OneDrive/Рабочий стол/Bootcamp/Bootcamp13/test.jpg')

#img = cv2.resize(img, (500, 500))

cv2.imshow('Result', img)

cv2.waitKey(0)