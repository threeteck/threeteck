﻿#include <iostream>
#include <windows.h>

using namespace std;

int main()
{
    SetConsoleOutputCP(CP_UTF8);
    cout << 
u8"ФИО - Загитов Артур Александрович\n\
Дата рождения - 17.02.2001\n\
Группа - 11 - 909\n\
Родился в Казани, учился в гимназии №122.\n\
Любимый язык программирования - C#, начал на нем писать впервые в 4 - ом классе.\n\
В шестом классе начал увлекаться олимпиадным программированием(и до сих пор увлекаюсь).\n\
Также я любил писать различные визуализации на Windows Forms, Unity, OpenGL(Tao Framework)\n\
и другие интересные мне проекты вроде интерпритатора собственного языка, движка для 3д графики и др.\n\
Однако с вебом никогда не работал, т.к раньше мне это было не очень интересно,\n\
но сейчас возникло желание попробовать, поэтому и записался на курс Django.\n";
}