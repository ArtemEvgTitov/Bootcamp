from turtle import *
from random import randint
from time import *

screen = Screen()
colormode(255)
finish = 200

t1 = Turtle()
t1.shape("turtle")
t1.color("red")
t1.penup()
t1.goto(-200, 20)
t1.pendown()
t1.speed(3)

t2 = Turtle()
t2.shape("turtle")
t2.color("blue")
t2.penup()
t2.goto(-200, -20)
t2.pendown()
t2.speed(3)

t3 = Turtle()
t3.shape("turtle")
t3.color("green")
t3.penup()
t3.goto(-200, -60)
t3.pendown()
t3.speed(3)


def razmetka():
    t = Turtle()
    t.speed(0)
    for i in range(1, 21):
        t.penup()
        t.goto(-200+i*20, 50)
        t.pendown()
        t.goto(-200+i*20, -100)
    t.hideturtle()


razmetka()


def catch1(x, y):
    t1.write('Ouch!', font=('Arial', 14, 'normal'))
    t1.fd(randint(10, 15))


t1.onclick(catch1)


def catch2(x, y):
    t2.write('Ouch!',  font=('Arial', 14, 'normal'))
    t2.fd(randint(10, 15))


t2.onclick(catch2)

def catch2(x, y):
    t3.write('Ouch!',  font=('Arial', 14, 'normal'))
    t3.fd(randint(10, 15))


t3.onclick(catch2)

while t1.xcor() < finish and t2.xcor() < finish and t3.xcor() < finish:
    t1.forward(randint(2, 7))
    t2.forward(randint(2, 7))
    t3.forward(randint(2, 7))
    sleep(0.05)

screen.exitonclick()
