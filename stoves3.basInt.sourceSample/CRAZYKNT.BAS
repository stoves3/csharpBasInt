DECLARE SUB KISSDIE ()
DECLARE SUB MUSIC ()
DECLARE SUB CREDITS ()
DECLARE SUB CUTPRINCESSFREE ()
DECLARE SUB LEAVEPRINCESS ()
DECLARE SUB TRYUNTIE ()
DECLARE SUB WINGAME ()
DECLARE SUB GETLAMP ()
DECLARE SUB GETSTRONG ()
DECLARE SUB KNOCKOUTWITCH ()
DECLARE SUB MOATDIE ()
DECLARE SUB POUROUTBOTTLE ()
DECLARE SUB SNAKEHOLEDIE ()
DECLARE SUB TRYTORUBLAMP ()
DECLARE SUB TURNEDTOFROG ()
DECLARE SUB LOSE ()
DECLARE SUB INSTRUCTIONS ()
DECLARE SUB JUMPOFFCLIFF ()
DECLARE SUB YELL ()
DECLARE SUB BUYBOMBS ()
DECLARE SUB ROCKGOBOOM ()
DECLARE SUB PULLSWORD ()
DECLARE SUB SCOREPRINT ()
DECLARE SUB WIMPEND ()
DECLARE SUB FINALSCORE ()
DECLARE SUB PLAYAGAIN ()
DECLARE SUB SCOREPRINT ()
DECLARE SUB SPACEBAR ()
DECLARE SUB INSTRUCTION ()
DECLARE SUB MAINMENU ()
DECLARE SUB EXITSCREEN ()
DECLARE SUB WARNING ()
CLS
SCREEN 0, 0
COLOR 4
LOCATE 5, 28
PRINT "STEPHEN MCKISIC PRESENTS:": SLEEP 1
COLOR 26
LOCATE 13, 32
PRINT "A CRAZY KNIGHT": SLEEP 4
MAINMENU
CHOICE:
        A$ = INKEY$
        A = VAL(A$)
        IF A = 1 THEN WARNING: GOTO GAME
        IF A = 2 THEN INSTRUCTIONS
        IF A = 2 THEN WARNING: GOTO GAME
        IF A = 3 THEN EXITSCREEN
        GOTO CHOICE
GAME:
CLS
LOCATE 10, 20: COLOR 10
INPUT "WHAT IS YOUR NAME, BRAVE KNIGHT"; N$
N$ = UCASE$(N$)
PRINT : PRINT , , "WELCOME, SIR "; N$; "!": SLEEP 2: COLOR 11: CLS
LOCATE 6, 8: PRINT "YOU, "; N$; ", BEING CHOSEN BY HIS EXCELLENCY, KING ARTHUR, HAVE"
LOCATE 8, 8: PRINT "BEEN GIVEN SOME MONEY, AND NOTHING MORE, TO GO OUT AND FIND THE"
LOCATE 10, 8: PRINT "WITCH'S CASTLE AND SAVE THE PRINCESS. ANY WEAPONS YOU MIGHT USE"
LOCATE 12, 8: PRINT "AGAINST THE WITCH CAN PROBABLY BE FOUND ALONG THE WAY."
PRINT : PRINT : PRINT : PRINT : PRINT : PRINT : PRINT , "     PRESS SPACEBAR TO BEGIN YOUR QUEST!"
COLOR 0
SPACEBAR
COLOR 11
S = 0
GOTO ALTFORK
FORK:
        CLS
ALTFORK:
        PRINT : PRINT : PRINT , "You are standing outside of the castle gate. You see a"
        PRINT , "dirt path that goes two directions. A sign is posted at"
        PRINT , "the fork in the path that reads:"
        PRINT : PRINT , "           ¯Bomb shop to the right.¯"
        PRINT , "        ®Road to witch's castle to the left.®"
        PRINT , "                       ÚÄÄÄÄÄ¿"
        PRINT , "            \    \     ³ ÷÷÷ ³     /    /"
        PRINT , "              \    \   ³ ÷÷÷ ³   /    /"
        PRINT , "                \    \ ÀÄÄÂÄÄÙ /    /"
        PRINT , "                  \    \  ³  /    /"
        PRINT , "                    \    \³/    /"
        PRINT , "                      \       /"
        PRINT , "                        \   /"
        PRINT : PRINT , "What will you do?"
        PRINT : PRINT , "1. Give up and go home."
        PRINT , "2. Follow the path to the right."
        PRINT , "3. Follow the path to the left."
        PRINT "    SCORE = "; S
CHOICE1:
                D$ = INKEY$
                D = VAL(D$)
                SELECT CASE D
                        CASE 1
                                WIMPEND
                                GOTO GAME
                        CASE 2
                                GOTO RIGHT
                        CASE 3
                                GOTO LEFT
                        CASE ELSE
                                GOTO CHOICE1
                END SELECT
LEFT:
CLS
PRINT : PRINT : PRINT , "You are on a small weather-beaten road on the"
PRINT , "way to Madam Mahem's castle. You can see the"
PRINT , "fork in the road with the sign behind you."
IF SW <> 1 THEN PRINT , "You see a sword embedded in a stone to the"
IF SW <> 1 THEN PRINT , "side of the road."
IF SW <> 1 THEN GOSUB LEFTPICTURE1: GOTO LEFTCHOICES
GOTO LEFTPICTURE2
LEFTPICTURE1:
        PRINT : PRINT , "           ³    ³        Ú¿"
        PRINT , "           ³    ³       ÈØØ¼"
        PRINT , "           ³    ³     ÚÄÄÁÁÄÄ¿"
        PRINT , "           ³    ³    /        \"
        PRINT , "           ³    ³  /            \"
        PRINT , "           ³    ³ ÀÄÄÄÄÄÄÄÄÄÄÄÄÄÄÙ"
        RETURN
LEFTPICTURE2:
        PRINT : PRINT , "           ³    ³"
        PRINT , "           ³    ³"
        PRINT , "           ³    ³"
        PRINT , "           ³    ³"
        PRINT , "           ³    ³"
        PRINT , "           ³    ³"
LEFTCHOICES:
PRINT : PRINT , "What will you do?"
        PRINT , "1. Give up and go home."
        PRINT , "2. Continue on down the path."
        PRINT , "3. Go back to the sign at the fork in the road."
        IF PS <> 1 AND SW <> 1 THEN PRINT , "4. Try to pull out the sword."
        IF PS = 1 AND SW <> 1 THEN PRINT , "4. Try to pull out the sword ... AGAIN."
        IF GB = 1 AND SW <> 1 THEN PRINT , "5. Blow up the rock with bombs."
        SCOREPRINT
CHOICE2:
        E$ = INKEY$
        E = VAL(E$)
IF E = 5 AND GB = 1 AND SW <> 1 THEN ROCKGOBOOM: GOTO LEFT
IF E = 4 AND SW <> 1 THEN PULLSWORD: GOTO LEFT
        SELECT CASE E
                CASE 1
                        WIMPEND
                        GOTO GAME
                CASE 2
                        GOTO SNAKEHOLE
                CASE 3
                        GOTO FORK
CASE ELSE
                        GOTO CHOICE2
        END SELECT
RIGHT:
        CLS
        PRINT : PRINT : PRINT , "You are standing beside a bomb shop.  The dirt"
        PRINT , "path that you are on leads to a cliff ahead."
        PRINT , "You can see the fork in the road with the sign"
        PRINT , "behind you."
        PRINT : PRINT , "           ÄÄÄÄÄÄÄÄÄÂÄÄÄÄÄÂÄÄÄÄÄÄÄÄÄÄÄÄ"
        PRINT , "                    ³     ³  ÚÄÄÄÄÄÄ¿   \"
        PRINT , "                    ³     ³ /ÂÄÄÄÄÄÄÂ\    \"
        PRINT , "                    ³     ³  ³ ÚÄÄ¿ ³ ÚÄÄÄ¿ \"
        PRINT , "                    ³     ³  ³ ³ù ³ ³ ³ ë ³   \"
        PRINT , "                    ³     ³  ÀÄÁÄÄÁÄÙ ÀÄÂÄÙ     \"
        PRINT , "                    ³     ³             ³         \"
        PRINT : PRINT , "What are you going to do?"
        PRINT : PRINT , "1. Give up and go home."
        PRINT , "2. Walk to the cliff."
        PRINT , "3. Go to the sign at the fork in the road."
        IF GB <> 1 THEN PRINT , "4. Buy bombs at the shop with money."
        SCOREPRINT
CHOICE3:
        F$ = INKEY$
        F = VAL(F$)
        IF F = 4 AND GB <> 1 THEN BUYBOMBS: GOTO RIGHT
        SELECT CASE F
                CASE 1
                        WIMPEND
                        GOTO GAME
                CASE 2
                        GOTO CLIFF
                CASE 3
                        GOTO FORK
                CASE ELSE
                        GOTO CHOICE3
END SELECT
CLIFF:
        CLS
        PRINT : PRINT , "You are standing at the edge of a cliff.  The path"
        PRINT , "leads off to the left, and behind you to a bombshop."
        IF CLJ <> 1 THEN PRINT , "You see a sign at the edge of the cliff that reads:"
        IF CLJ <> 1 THEN PRINT , "              ¯Jump ... I dare you!®"
        IF CLJ <> 1 THEN GOSUB CLIFFPICTURE1: GOTO CHOICES4
        GOSUB CLIFFPICTURE2: GOTO CHOICES4
CLIFFPICTURE1:
        PRINT
        PRINT , "                      ÚÄÄÄ¿"
        PRINT , "                      ³÷÷÷³"
        PRINT , "                      ÀÄÂÄÙ"
        PRINT , "           ÄÄÄÄÄÄÄÄÄÄÄÄÄÅÄÄÄ"
        PRINT , "                             \"
        PRINT , "           ÄÄÄÄÄÄÄÄÄÄÄÄ¿       \"
        PRINT , "                       ³         \"
        PRINT , "           ÄÄÄÄÄÄ¿     ³           \"
        RETURN
CLIFFPICTURE2:
        PRINT : PRINT : PRINT
        PRINT , "           ÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄ"
        PRINT , "                             \"
        PRINT , "           ÄÄÄÄÄÄÄÄÄÄÄÄ¿       \"
        PRINT , "                       ³         \"
        PRINT , "           ÄÄÄÄÄÄ¿     ³           \"
        RETURN
CHOICES4: 
        PRINT : PRINT , "What are you going to do now?"
        PRINT : PRINT , "1. Give up and go home."
        PRINT , "2. Follow the path to the left."
        PRINT , "3. Follow the path to the bombshop."
        PRINT , "4. Yell."
        IF CLJ <> 1 THEN PRINT , "5. Jump off the cliff."
        SCOREPRINT
CHOICE4:
        G$ = INKEY$
        G = VAL(G$)
        IF CLJ <> 1 AND G = 5 THEN JUMPOFFCLIFF: GOTO CLIFF
        SELECT CASE G
                CASE 1
                        WIMPEND
                        GOTO GAME
                CASE 2
                        GOTO SNAKEHOLE
                CASE 3
                        GOTO RIGHT
                CASE 4
                        YELL
                        GOTO CLIFF
                CASE ELSE
                        GOTO CHOICE4
        END SELECT
SNAKEHOLE:
        CLS
SNAKEHOLEALT: 
        PRINT : PRINT , "You are at an intersection in the path. There is a"
        PRINT , "conspicuous looking hole to the side. Up the path,"
        PRINT , "you can make out the witch's castle. Over to the"
        PRINT , "right, you can see a cliff with a sign at its edge."
        IF SW <> 1 THEN PRINT , "Behind you is a sword in a stone."
        IF SW = 1 THEN PRINT , "You can see the path behind you where the sword in"
        IF SW = 1 THEN PRINT , "the stone used to be."
        PRINT : PRINT , "             ³    ³"
        PRINT , "       ÜÜÜÜÜ ³    ³"
        PRINT , "       Û   Û ³    ÀÄÄ"
        PRINT , "       ÛÜÜÜÛ ³"
        PRINT , "             ³    ÚÄÄ"
        PRINT : PRINT , "What are you going to do?"
        PRINT : PRINT , "1. Give up and go home."
        PRINT , "2. Continue on to the witch's castle."
        PRINT , "3. Follow the path to the right."
        IF SW <> 1 THEN PRINT , "4. Go to the sword in the stone behind you."
        IF SW = 1 THEN PRINT , "4. Go back to where the sword in the stone used to be."
        IF GL <> 1 THEN PRINT , "5. Stick your head in the hole."
        IF GL <> 1 AND CLJ = 1 AND SH <> 1 THEN PRINT , "6. Pour SNAKE-BE-GONE down the hole."
        SCOREPRINT
CHOICE5:
        H$ = INKEY$
        H = VAL(H$)
        IF H = 5 AND SH <> 1 THEN SNAKEHOLEDIE
        IF H = 5 AND SH <> 1 THEN GOTO GAME
        IF H = 5 AND SH = 1 AND GL <> 1 THEN GETLAMP: GOTO SNAKEHOLEALT
        IF H = 6 AND CLJ = 1 AND SH <> 1 THEN POUROUTBOTTLE: GOTO SNAKEHOLEALT
        SELECT CASE H
                CASE 1
                        WIMPEND
                        GOTO GAME
                CASE 2
                        GOTO OUTSIDECASTLE
                CASE 3
                        GOTO CLIFF
                CASE 4
                        GOTO LEFT
                CASE ELSE
                        GOTO CHOICE5
        END SELECT
OUTSIDECASTLE:
        CLS
OUTSIDECASTLEALT: 
        PRINT , "You have arrived at Madam Mahem's castle! A moat surrounds"
        PRINT , "the fortress and a huge dark cloud looms overhead. You can"
        PRINT , "hear a cry for help coming from the single forboding tower."
        IF DR <> 1 THEN PRINT , "Unfortunately, the drawbridge is up."
        IF DR = 1 THEN PRINT , "The drawbridge is down!"
        IF DR <> 1 THEN GOSUB CASTLEPICTURE1: GOTO CHOICES6
        GOSUB CASTLEPICTURE2: GOTO CHOICES6
CASTLEPICTURE1:
        PRINT , "         ________  /\ ________"
        PRINT , "        (   (    /    \    )   )"
        PRINT , "       (  (    ( ³    ³ )    )  )"
        PRINT , "       (     (   ³ ÞÝ ³   )     )"
        PRINT , "        (___ÚÄ¿_ÚÁ¿  ÚÁ¿_ÚÄ¿___)"
        PRINT , "            ³ ÀÄÙ ÀÄÄÙ ÀÄÙ ³"
        PRINT , "            ³  Û  ÚÂÂ¿  Û  ³"
        PRINT , "          ÚÄ´     ³³³³     ÃÄ¿"
        PRINT , "          ³÷ÀÄÄÄÄÄÁÁÁÁÄÄÄÄÄÙ÷³"
        PRINT , "          ³÷÷÷÷÷÷÷÷÷÷÷÷÷÷÷÷÷÷³"
        PRINT , "          ÀÄÄÄÄÄÄÂÄÄÄÄÂÄÄÄÄÄÄÙ"
        PRINT , "                 ³    ³"
        RETURN
CASTLEPICTURE2:
        PRINT , "         ________  /\ ________"
        PRINT , "        (   (    /    \    )   )"
        PRINT , "       (  (    ( ³    ³ )    )  )"
        PRINT , "       (     (   ³ ÞÝ ³   )     )"
        PRINT , "        (___ÚÄ¿_ÚÁ¿  ÚÁ¿_ÚÄ¿___)"
        PRINT , "            ³ ÀÄÙ ÀÄÄÙ ÀÄÙ ³"
        PRINT , "            ³  Û  ÚÄÄ¿  Û  ³"
        PRINT , "          ÚÄ´     ³  ³     ÃÄ¿"
        PRINT , "          ³÷ÀÄÄÄÄÄÅÂÂÅÄÄÄÄÄÙ÷³"
        PRINT , "          ³÷÷÷÷÷÷÷³³³³÷÷÷÷÷÷÷³"
        PRINT , "          ÀÄÄÄÄÄÄÂÁÁÁÁÂÄÄÄÄÄÄÙ"
        PRINT , "                 ³    ³"
        RETURN
CHOICES6:
        PRINT , "What are you going to do?"
        PRINT , "1. Give up and go home."
        PRINT , "2. Swim across the moat."
        PRINT , "3. Go back to the intersection with the hole behind you."
        IF GL = 1 AND DR <> 1 THEN PRINT , "4. Try to rub your lamp."
        IF GL = 1 AND DR <> 1 THEN PRINT , "5. Drink the stuff that's in the lamp."
        IF DR = 1 THEN PRINT , "4. Enter the castle!"
        SCOREPRINT
CHOICE6:
        I$ = INKEY$
        I = VAL(I$)
        IF I = 4 AND GL = 1 AND DR <> 1 THEN TRYTORUBLAMP: GOTO OUTSIDECASTLE
        IF I = 5 AND GL = 1 AND DR <> 1 THEN GETSTRONG: GOTO OUTSIDECASTLEALT
        IF I = 4 AND DR = 1 AND MMD <> 1 THEN GOTO INSIDECASTLE
        IF I = 4 AND DR = 1 AND MMD = 1 THEN GOTO ATPRINCESS
        SELECT CASE I
                CASE 1
                        WIMPEND
                        GOTO GAME
                CASE 2
                        MOATDIE
                        GOTO GAME
                CASE 3
                        GOTO SNAKEHOLE
                CASE ELSE
                        GOTO CHOICE6
        END SELECT
INSIDECASTLE:
        CLS
        PRINT : PRINT : PRINT , "You rush into the castle and up the tower stairs!"
        PRINT , "As you reach the top of the tower you see Madam"
        PRINT , "Mahem herself flying straight at you! You have"
        PRINT , "time to do only one thing!"
        PRINT , "        THIS IS THE MOMENT OF TRUTH!!!"
        PRINT : PRINT , "                  /\"
        PRINT , "                ÄÁÄÄÁÄ"
        PRINT , "                /. \\\"
        PRINT , "               /_  ÀÀÀÄ"
        PRINT , "                /__/ÀÀÄ"
        PRINT , "                /  ³\___"
        PRINT , "              / /³ ³    / /"
        PRINT , "          ÍÍÍÊÍÊÍÍ^³ÍÍÍ Ä -"
        PRINT , "                 ¼ ¼    \ \"
        PRINT : PRINT , "What are you going to do?"
        PRINT , "1. Run back out of the castle."
        PRINT , "2. Duck."
        IF SW = 1 THEN PRINT , "3. Try to cut the broom in half as the witch flys by."
        SCOREPRINT
CHOICE7:
        J$ = INKEY$
        J = VAL(J$)
        IF J = 3 AND SW = 1 THEN TURNEDTOFROG
        IF J = 3 AND SW = 1 THEN GOTO GAME
        SELECT CASE J
                CASE 1
                        GOTO OUTSIDECASTLE
                CASE 2
                        KNOCKOUTWITCH
                        GOTO ATPRINCESS
                CASE ELSE
                        GOTO CHOICE7
        END SELECT
ATPRINCESS:
        CLS
        PRINT : PRINT : PRINT , "Behind the knocked down wall you see Princess Gwendolin"
        PRINT , "tied to a chair and screaming for help! Immediately, you"
        PRINT , "rush to her side."
        PRINT , "                 ______      ÷÷÷÷÷"
        PRINT , "                /       \   /Ä ÷÷÷÷"
        PRINT , "               ³ HELP!!   \À_   ÷÷÷÷"
        PRINT , "               ³ HELP!!   / /___/÷÷"
        PRINT , "                \______ /   /   \º"
        PRINT , "                            \ ³³ º"
        PRINT , "                             ÆØØÍ¹"
        PRINT , "                            / È¼ º"
        PRINT , "                          /  ÉÏÍÍ¹"
        PRINT , "                        /___/º   º"
        PRINT , "                         ¼ ¼ º   º"
        PRINT , "What are you going to do?"
        PRINT : PRINT , "1. Run back out of the castle."
        PRINT , "2. Try to untie her."
        PRINT , "3. Give her a kiss."
        IF SW = 1 THEN PRINT , "4. Cut the ropes with your sword."
        SCOREPRINT
CHOICE8:
        K$ = INKEY$
        K = VAL(K$)
        IF K = 4 AND SW = 1 THEN CUTPRINCESSFREE
        IF K = 4 AND SW = 1 THEN WINGAME
        SELECT CASE K
                CASE 1
                        LEAVEPRINCESS
                        GOTO OUTSIDECASTLE
                CASE 2
                        TRYUNTIE
                        GOTO ATPRINCESS
                CASE 3
                        KISSDIE
                        GOTO GAME
                CASE ELSE
                        GOTO CHOICE8
        END SELECT

SUB BUYBOMBS
CLS
SHARED GB, S
LOCATE 10, 30
PRINT "YOU GOT SOME BOMBS!!"
SLEEP 2
LOCATE 13, 35
PRINT "10 POINTS!"
GB = 1
S = S + 10
SPACEBAR
CLS
END SUB

SUB CREDITS
CLS
LOCATE 23, 34
COLOR 4
PRINT "C R E D I T S"
PRINT , , "     -------------"
COLOR 2
GOSUB PAUSE1
PRINT , , "      STORY WRITER:"
GOSUB PAUSE2
PRINT , , "     STEPHEN MCKISIC"
COLOR 3
GOSUB PAUSE1
PRINT , , "       PROGRAMMER:"
GOSUB PAUSE2
PRINT , , "     STEPHEN MCKISIC"
COLOR 1
GOSUB PAUSE1
PRINT , , "    GRAPHICS DESIGNER:"
GOSUB PAUSE2
PRINT , , "     STEPHEN MCKISIC"
COLOR 5
GOSUB PAUSE1
PRINT , , "         EDITOR:"
GOSUB PAUSE2
PRINT , , "     STEPHEN MCKISIC"
COLOR 14
GOSUB PAUSE1
PRINT , , "    SPECIAL THANKS TO:"
GOSUB PAUSE2
PRINT , , "     STEPHEN MCKISIC"
COLOR 10
GOSUB PAUSE1
PRINT , , "   EXECUTIVE PRODUCER:"
GOSUB PAUSE2
PRINT , , "     STEPHEN MCKISIC"
COLOR 13
GOSUB PAUSE1
PRINT , , "Copyright 1995, SDM Inc."
GOSUB PAUSE3
COLOR 15
PRINT , , "      T H E  E N D"
GOSUB PAUSE1: GOSUB PAUSE2: GOSUB PAUSE2: GOSUB PAUSE2
SLEEP 20
CLS
END
PAUSE1:
        PLAY "P8": PRINT : PLAY "P8": PRINT : PLAY "P8": PRINT : PLAY "P8": PRINT
        PLAY "P8": PRINT : PLAY "P8": PRINT : PLAY "P8": PRINT : PLAY "P8": PRINT
        RETURN
PAUSE2:
        PLAY "P8": PRINT
        RETURN
PAUSE3:
        PLAY "P8": PRINT : PLAY "P8": PRINT : PLAY "P8": PRINT : PLAY "P8": PRINT
        PLAY "P8": PRINT : PLAY "P8": PRINT : PLAY "P8": PRINT : PLAY "P8": PRINT
        PLAY "P8": PRINT : PLAY "P8": PRINT : PLAY "P8": PRINT : PLAY "P8": PRINT
        PLAY "P8": PRINT : PLAY "P8": PRINT : PLAY "P8": PRINT : PLAY "P8": PRINT
        RETURN
END SUB

SUB CUTPRINCESSFREE
SHARED S
CLS
LOCATE 9, 15
PRINT "YOU KNEW THERE WAS A REASON FOR GETTING THIS SWORD!"
LOCATE 11, 20
PRINT "YOU CAREFULLY CUT PRINCESS GWENDOLIN FREE!"
SLEEP 3
LOCATE 13, 35
PRINT "100 POINTS!"
S = S + 100
SPACEBAR
END SUB

SUB EXITSCREEN
CLS
COLOR 14
LOCATE 10, 36
PRINT "SEE YA!"
SLEEP 2
CLS
END
END SUB

SUB FINALSCORE
SHARED S
LOCATE 20, 14
PRINT "FINAL SCORE = "; S; "POINTS OUT OF 210 POINTS POSSIBLE."
END SUB

SUB GETLAMP
CLS
SHARED GL, S
LOCATE 8, 9
PRINT "YOU LOOK IN THE HOLE AND SEE HUNDREDS OF SHRIVELED-UP SNAKES."
SLEEP 2
LOCATE 10, 3
PRINT "YOU NOTICE AT THE BACK OF THE HOLE AN OLD DUSTY OIL LAMP, WHICH YOU TAKE."
SLEEP 2
LOCATE 12, 35
PRINT "20 POINTS!"
SPACEBAR
GL = 1
S = S + 20
CLS
END SUB

SUB GETSTRONG
CLS
SHARED DR, S
LOCATE 6, 5
PRINT "AS YOU DRINK THE LIQUID FROM THE LAMP, YOU BECOME INCREDIBLY STRONG!!"
SLEEP 2
LOCATE 8, 13
PRINT "YOU LEAP ACROSS THE MOAT AND PULL DOWN THE DRAWBRIDGE!"
SLEEP 2
LOCATE 10, 15
PRINT "UNFORTUNATELY, YOU USE UP ALL YOUR EXTRA STRENGTH,"
LOCATE 12, 24
PRINT "BUT AT LEAST THE BRIDGE IS DOWN!"
SLEEP 2
LOCATE 14, 35
PRINT "10 POINTS!"
SLEEP 2
DR = 1
S = S + 10
SPACEBAR
CLS
END SUB

SUB INSTRUCTIONS
CLS
COLOR 10
PRINT : PRINT : PRINT , "WELCOME TO"
LOCATE 3, 26
COLOR 20
PRINT "A CRAZY KNIGHT"
COLOR 10
LOCATE 3, 40
PRINT "!!"
PRINT : PRINT "CONGRATULATATIONS!  YOU HAVE BEEN CALLED UPON BY HIS EXCELLENCY:"
COLOR 9
PRINT : PRINT , , "KING ARTHUR!!"
COLOR 10
PRINT : PRINT "THE BEAUTIFUL PRINCESS GWENDOLIN HAS BEEN CAPTURED BY THE WICKED WITCH,"
PRINT "MADAM MAHEM!"
PRINT , "YOUR JOB (AS THE ONLY KNIGHT LEFT) IS TO SAVE THE PRINCESS AND THE KINGDOM"
PRINT "FROM THE CLUTCHES OF THE EVIL WITCH AND HER CRONIES."
PRINT : PRINT , "ARE YOU CRAZY ENOUGH TO TAKE UP THE CHALLENGE? (Y OR N)"
INSTRUCTIONSCHOICE:
        B$ = INKEY$
        B$ = UCASE$(B$)
        SELECT CASE B$
                CASE "N"
                        GOTO INSTRUCTIONS1
                CASE "Y"
                        GOTO INSTRUCTIONS2
                CASE ELSE
                        GOTO INSTRUCTIONSCHOICE
        END SELECT
INSTRUCTIONS1:
        COLOR 9
        PRINT : PRINT , "TOO BAD.  I KNEW YOU WEREN'T BRAVE ENOUGH."
        SLEEP 3
        CLS
        COLOR 14
        LOCATE 10, 36
        PRINT "SEE YA!"
        SLEEP 2
        CLS
        END
INSTRUCTIONS2:
        COLOR 9
        PRINT : PRINT , "     GREAT!  GO FORTH TO SAVE THE PRINCESS!!"
        SLEEP 3
END SUB

SUB JUMPOFFCLIFF
CLS
SHARED CLJ, S
LOCATE 8, 21
PRINT "Where did you get an idea like that???"
LOCATE 9, 7
PRINT "Fortunately for you, the programmer of this game is a nice guy ..."
SLEEP 3
LOCATE 11, 10
PRINT "PUFF, THE MAGIC DRAGON FLYS BY AND CATCHES YOU ON HIS BACK."
SLEEP 2
LOCATE 13, 10
PRINT "HE SETS YOU BACK ON THE CLIFF AND RIPS THE SIGN TO SHREDS."
SLEEP 2
LOCATE 15, 10
PRINT "THEN, HE GIVES YOU A BOTTLE OF SNAKE-BE-GONE AND FLYS AWAY."
SLEEP 2
LOCATE 17, 35
PRINT "10 POINTS!"
SPACEBAR
CLJ = 1
S = S + 10
CLS
END SUB

SUB KISSDIE
CLS
LOCATE 6, 17
PRINT "Hey!! Wait a minute! You should know better!!"
LOCATE 8, 22
PRINT "This game was written at Bob Jones!!"
SLEEP 3
LOCATE 10, 9
PRINT "The infuriated Princess Gwendolin snaps the ropes and slaps you"
LOCATE 12, 7
PRINT "across the face, sending you flying backwards out the tower window!"
SLEEP 3
LOCATE 14, 5
PRINT "You fall into the moat where the man-eating crocodiles are waiting!"
SLEEP 1
SPACEBAR
LOSE
END SUB

SUB KNOCKOUTWITCH
CLS
SHARED MMD, S
LOCATE 8, 7
PRINT "YOU DUCK, AND SINCE MADAM MAHEM HAS ONLY HAD HER BROOM FOR A WEEK,"
LOCATE 10, 8
PRINT "SHE LOSES CONTROL AND CAREENS OVER YOUR HEAD. THEN SHE CLUMSILY"
LOCATE 12, 9
PRINT "SLAMS INTO THE WALL, KNOCKING HERSELF OUT, AND THE WALL DOWN!!"
LOCATE 14, 24
PRINT "YOU HAVE DEFEATED MADAM MAHEM!!!"
SLEEP 5
LOCATE 16, 35
PRINT "50 POINTS!"
MMD = 1
S = S + 50
SPACEBAR
CLS
END SUB

SUB LEAVEPRINCESS
CLS
LOCATE 9, 10
PRINT "As you run off, the princess stares at you with indignation,"
LOCATE 11, 18
PRINT "and then she resumes her screaming for help."
SLEEP 3
SPACEBAR
END SUB

SUB LOSE
CLS
COLOR 14
LOCATE 7, 35
PRINT "TOO BAD ..."
SLEEP 3
LOCATE 10, 32
PRINT "Y O U  L O S E !"
SLEEP 3
FINALSCORE
SPACEBAR
PLAYAGAIN
END SUB

SUB MAINMENU
CLS
COLOR 9
LOCATE 5, 30
PRINT "M E N U"
LOCATE 6, 30
PRINT "-------"
LOCATE 10, 27
PRINT "1. PLAY GAME"
LOCATE 13, 27
PRINT "2. INSTRUCTIONS"
LOCATE 16, 27
PRINT "3. EXIT PROGRAM"
END SUB

SUB MOATDIE
CLS
LOCATE 8, 9
PRINT "As you dive into the moat, you realize you are surrounded by:"
SLEEP 2
LOCATE 10, 28
PRINT "MAN-EATING CROCODILES!!!"
SLEEP 2
LOCATE 12, 27
PRINT "Looks like this is the end!"
SPACEBAR
LOSE
END SUB

SUB MUSIC
PLAY "O2B-3B-16B-16B-16B-16B-8A-16B-3B-16B-16B-16B-16B-8A-16B-3B-16B-16B-16B-16B-16F16F16F16F16F16F16F16F16F16F16F16B-6F4B-9B-16O3C16D16E-16F3F9F12G16A-16B-3B-9B-16A-16G-16A-9G-12F3F9E-8E-16F16G-3F9E-8D-12D-16E-16F3E-9D-8C12C16D-16E-3G-6F12P32O2B-16B-16B-16P32B-16B-16B-6P32O1B-3"
END SUB

SUB PLAYAGAIN
SHARED GB, SW, CLJ, GL, SH, PS, DR, MMD
CLS
COLOR 14
LOCATE 10, 27
GB = 0
SW = 0
CLJ = 0
GL = 0
SH = 0
PS = 0
DR = 0
MMD = 0
PRINT "DO YOU WANT TO PLAY AGAIN?"
CHOICEPLAYAGAIN:
        PA$ = INKEY$
        PA$ = UCASE$(PA$)
        SELECT CASE PA$
                CASE "Y"
                        COLOR 9
                        PRINT : PRINT , "     GREAT!  GO FORTH TO SAVE THE PRINCESS!!"
                        SLEEP 2
                        GOTO OVER
                CASE "N"
                        EXITSCREEN
                CASE ELSE
                        GOTO CHOICEPLAYAGAIN
        END SELECT
OVER:
END SUB

SUB POUROUTBOTTLE
CLS
SHARED SH
LOCATE 8, 3
PRINT "AS YOU POUR OUT THE SNAKE-BE-GONE INTO THE HOLE, YOU HEAR A LOUD HISS COMING"
LOCATE 10, 33
PRINT "FROM THE HOLE."
SPACEBAR
SH = 1
CLS
END SUB

SUB PULLSWORD
SHARED PS
CLS
LOCATE 10, 15
PRINT "Though you try hard, you can't pull out the sword."
SLEEP 2
LOCATE 12, 19
PRINT "Face the facts ... You're just a weakling."
PS = 1
SPACEBAR
CLS
END SUB

SUB ROCKGOBOOM
CLS
SHARED SW, S
COLOR 26
LOCATE 10, 34
PRINT "B O O M ! ! "
SLEEP 3
CLS
LOCATE 10, 20
COLOR 11
PRINT "YOU BLEW UP THE ROCK AND GOT THE SWORD!"
SLEEP 2
LOCATE 13, 35
PRINT "10 POINTS"
SW = 1
S = S + 10
SPACEBAR
CLS
END SUB

SUB SCOREPRINT
SHARED S
LOCATE 23, 5
PRINT "SCORE = "; S
END SUB

SUB SNAKEHOLEDIE
SHARED N$
CLS
LOCATE 8, 8
PRINT "You have just stuck your head into a hole full of deadly snakes!"
SLEEP 2
LOCATE 10, 25
PRINT "Eeeeeeew, bad move "; N$; "!"
SLEEP 2
LOCATE 12, 11
PRINT "You die a very quick, but very painful death, as hundreds"
LOCATE 13, 14
PRINT "of venomous snakes sink their fangs into your face!"
SPACEBAR
LOSE
END SUB

SUB SPACEBAR
LOCATE 23, 5
PRINT "PRESS < S P A C E B A R >"
INPUTSPACE:
        S$ = INKEY$
        IF S$ <> " " THEN GOTO INPUTSPACE
END SUB

SUB TRYTORUBLAMP
CLS
LOCATE 7, 28
PRINT "You rub the lamp AND ..."
SLEEP 3
LOCATE 9, 32
PRINT "Nothing happens."
SLEEP 2
LOCATE 13, 28
PRINT "(What did you expect ...)"
SLEEP 1
LOCATE 15, 35
PRINT "(a genie?)"
SLEEP 1
LOCATE 17, 28
PRINT "(Ha,ha,ha,ha,ha,ha, ...)"
SPACEBAR
CLS
END SUB

SUB TRYUNTIE
CLS
LOCATE 9, 16
PRINT "You try hard to untie the ropes, but you can't."
SLEEP 2
LOCATE 11, 17
PRINT "Face the facts ... you are just a big weakling."
SLEEP 1
SPACEBAR
END SUB

SUB TURNEDTOFROG
CLS
LOCATE 8, 9
PRINT "You attempt to cut the broom in half as th witch flys by, but"
LOCATE 10, 17
PRINT "you miss and the witch turns you into a toad!!"
SLEEP 3
LOCATE 12, 31
PRINT "Have a HOPPY life!"
SPACEBAR
LOSE
END SUB

SUB WARNING
CLS
COLOR 20
LOCATE 10, 30
PRINT "W A R N I N G ! !"
SLEEP 2
COLOR 4
PRINT : PRINT : PRINT , "THIS GAME IS MOSTLY A TEXT GAME.  YOU WILL BE"
PRINT , "REQUIRED TO USE YOUR IMAGINATION FOR A CHANGE."
PRINT : PRINT "ARE YOU STILL A LOYAL KNIGHT AND WILLING TO CONTINUE? (Y OR N)"
WARNINGCHOICE:
        C$ = INKEY$
        C$ = UCASE$(C$)
        SELECT CASE C$
                CASE IS = "N"
                        COLOR 14
                        PRINT , , "      WIMP!!"
                        SLEEP 1
                        EXITSCREEN
                CASE IS = "Y"
                        COLOR 14
                        PRINT , , "      GREAT!"
                        SLEEP 1
                        GOTO WARNINGOVER
                CASE ELSE
                        GOTO WARNINGCHOICE
        END SELECT
WARNINGOVER:
        END SUB

SUB WIMPEND
CLS
COLOR 14
LOCATE 10, 37
PRINT "YOU WIMP!"
SLEEP 2
CLS
LOCATE 7, 35
PRINT "TOO BAD ..."
SLEEP 3
LOCATE 10, 32
PRINT "Y O U  L O S E !"
SLEEP 3
FINALSCORE
SPACEBAR
PLAYAGAIN
END SUB

SUB WINGAME
CLS
COLOR 26
LOCATE 5, 30
PRINT "CONGRATULATIONS!!!!!"
COLOR 14
LOCATE 8
PRINT , "YOU HAVE SAVED THE PRINCESS AND THE KINGDOM FROM MADAM MAHEM!"
PRINT , "KING ARTHUR AND HIS SUBJECTS THANK YOU HEARTILY AND CELEBRATE"
PRINT , "YOUR VICTORY WITH A HUGE FESTIVAL! YOU ARE GIVEN A HIGH RANK"
PRINT , "IN THE KING'S ARMY, AND, AS IN ALL GOOD FAIRY TALES,"
PRINT : PRINT , "       EVERYONE LIVES HAPPILY EVER AFTER!!!"
FINALSCORE
MUSIC
SPACEBAR
CLS
CREDITS
END SUB

SUB YELL
CLS
LOCATE 9, 14
PRINT "You yell loudly, but all that responds is your echo."
SLEEP 2
LOCATE 11, 28
PRINT "Boy, that was pointless!"
SPACEBAR
CLS
END SUB

