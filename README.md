Данный проект создан в рамках обучающего курса по созданию игры на C# WinForms с небольшими личными доработками.
Ссылка на курс: https://www.youtube.com/playlist?list=PL0lO_mIqDDFWdwhHdoo66yGqrSzg95Bde

Максимально кратко про структуру проекта:
Вся логика программы написана в файле Form1.cs, в ней содержится абсолютно всё.
В файле Form1.Designer.cs отображаются все элементы формы, созданные мной (они создаются автоматически, так что не знаю зачем я указываю это здесь =) )

Геймплей:
 - При запуске программы открывается окно с игрой. Его можно свободно перемещать по экрану, кроме случая, когда игра запущена и происходит основной экшен;
 - Перед началом игры выбирается сложность: Beginner, Advanced или Professional (не ожидайте здесь баланса, его нет);
 - Когда сложность выбрана, можно запустить игру, нажав на кнопку START (помните, что у вас нет времени на подумать, игра стартует моментально);
 - В ходе игры нужно уворачиваться от противников и собирать монетки, количество собранных монеток отображается в верхнем левом углу (также число собранных монет посмотреть при поражении);
 - Управляется машинка клавишами A D или Левая и Правая стрелочки;
 - Если ваша машинка столкнется с противником, игра закончится - вы проиграли;
 - Чтобы начать заново, нажмите кнопку Try Again;
 - Чтобы выйти в меню при поражении, нажмите кнопку Main Menu;
 - Чтобы выйти из приложения, нажмите клавишу Esc или кнопку Quit;
 - Во время игры в левом нижнем углу отображаюся fps, max fps, ticktime и frames (фреймы обнуляются каждую минуту). С помощью них вы можете понаблюдать, насколько оптимизированно у вас запускается игра (например у меня это следующие значения: при сложности Beginner fps 40-63, при Advanced 45-61, при Professional 58-61).

Вот и всё, спасибо за прочтение и ознакомление!

P.S.: оставил небольшую фичу, чтобы проще было посмотреть на фпсы и на сам ход игры: если въехать в самую правую точку, то ехать вы будете бесконечно - противники просто там не появляются, но имейте ввиду, что и монетки тоже там появляться не будут.\
Если хотите убрать это, замените значение 560 на 700 в следующих строках файла Form1.cs:
```//Движение монеток
<..>
coin.Left = rand.Next(150, 560);

//Движение противников
<..>
enemy2.Left = rand.Next(420, 560);```
