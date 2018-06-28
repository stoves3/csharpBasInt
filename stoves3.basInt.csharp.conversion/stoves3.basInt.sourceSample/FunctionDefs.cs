using System;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.InteropServices;
using System.Security.Principal;
using System.Text;
using stoves3.basInt.csharp.basFuncs;
using stoves3.basInt.csharp.core;

namespace stoves3.basInt.sourceSample
{
    public class FunctionDefs
    {
        private IScreen _screen;

        public FunctionDefs()
        {
        }

        public void Run()
        {
            SCREEN(0, 0);
            COLOR(4);
            LOCATE(5, 28);
            PRINT(Strings.Intro.STEPHENMCKISICPRESENTS); SLEEP(1);
            COLOR(26);
            LOCATE(13, 32);
            PRINT(Strings.Intro.ACRAZYKNIGHT); SLEEP(4);

            MAINMENU:
            CHOICE:
                var AṨ = INKEYṨ();
                var A = VAL(AṨ);
                if (A == 1) { if (WARNING()) goto END; goto GAME; }
                if (A == 2) { if (INSTRUCTIONS()) goto END; }
                if (A == 2) { if (WARNING()) goto END; goto GAME; }
                if (A == 3) { EXITSCREEN(); goto END; }
                goto CHOICE;
            GAME:
            CLS();
            LOCATE(10, 20); COLOR(10);

            string NṨ;
            INPUT(Strings.Intro.WHATISYOURNAMEBRAVEKNIGHT, out NṨ);
            NṨ = UCASEṨ(NṨ);
            PRINT(); PRINT(tab: true); PRINT(tab: true); PRINT(Strings.Game.PtnWELCOMESIR, false, NṨ); SLEEP(2); COLOR(11); CLS();
            LOCATE(6, 8); PRINT(Strings.Game.PtnYOUBEINGCHOSENBYHISEXCELLENCYKINGARTHURHAVE, false, NṨ);
            LOCATE(8, 8); PRINT(Strings.Game.BEENGIVENSOMEMONEYANDNOTHINGMORETOGOOUTANDFINDTHE);
            LOCATE(10, 8); PRINT(Strings.Game.WITCHSCASTLEANDSAVETHEPRINCESSANYWEAPONSYOUMIGHTUSE);
            LOCATE(12, 8); PRINT(Strings.Game.AGAINSTTHEWITCHCANPROBABLYBEFOUNDALONGTHEWAY);
            PRINT(); PRINT(); PRINT(); PRINT(); PRINT(); PRINT(); PRINT(tab: true); PRINT(Strings.Game.PRESSSPACEBARTOBEGINYOURQUEST);
            COLOR(0);
            SPACEBAR();
            COLOR(11);
            var S = 0;
            goto ALTFORK;
            FORK:
                CLS();
            ALTFORK:
                PRINT(); PRINT(); PRINT(tab: true); PRINT(Strings.Fork.YouarestandingoutsideofthecastlegateYouseea);
                PRINT(tab: true); PRINT(Strings.Fork.dirtpaththatgoestwodirectionsAsignispostedat);
                PRINT(tab: true); PRINT(Strings.Fork.theforkinthepaththatreads);
                PRINT(); PRINT(tab: true); PRINT(Strings.Fork.Bombshoptotheright);
                PRINT(tab: true); PRINT(Strings.Fork.Roadtowitchscastletotheleft);
                PRINT(tab: true); PRINT(Strings.Fork.TopOfForkRoadSign);
                PRINT(tab: true); PRINT(Strings.Fork.ForkRoadSignL1);
                PRINT(tab: true); PRINT(Strings.Fork.ForkRoadSignL2);
                PRINT(tab: true); PRINT(Strings.Fork.ForkRoadSignL3);
                PRINT(tab: true); PRINT(Strings.Fork.ForkRoadSignL4);
                PRINT(tab: true); PRINT(Strings.Fork.ForkRoadSignL5);
                PRINT(tab: true); PRINT(Strings.Fork.ForkRoadSignL6);
                PRINT(tab: true); PRINT(Strings.Fork.ForkRoadSignL7);
                PRINT(); PRINT(tab: true); PRINT(Strings.Fork.Whatwillyoudo);
                PRINT(); PRINT(tab: true); PRINT(Strings.Fork.c1Giveupandgohome);
                PRINT(tab: true); PRINT(Strings.Fork.c2Followthepathtotheright);
                PRINT(tab: true); PRINT(Strings.Fork.c3Followthepathtotheleft);
                PRINT(Strings.Fork.PtnSCORE, false, S);
            CHOICE1:
                var DṨ = INKEYṨ();
                var D = VAL(DṨ);
                switch (D)
                {
                    case 1:
                        if (WIMPEND()) goto END;
                        goto GAME;
                    case 2:
                        goto RIGHT;
                    case 3:
                        goto LEFT;
                    default:
                        goto CHOICE1;
                }
            LEFT:
            CLS();
            PRINT(); PRINT(); PRINT(tab: true); PRINT(Strings.Left.Youareonasmallweatherbeatenroadonthe);
            PRINT(tab: true); PRINT(Strings.Left.waytoMadamMahemscastleYoucanseethe);
            PRINT(tab: true); PRINT(Strings.Left.forkintheroadwiththesignbehindyou);
            if (SW != 1) { PRINT(tab: true); PRINT(Strings.Left.Youseeaswordembeddedinastonetothe); }
            if (SW != 1) { PRINT(tab: true); PRINT(Strings.Left.sideoftheroad); }
            if (SW != 1) { LEFTPICTURE1(); goto LEFTCHOICES; }
            goto LEFTPICTURE2;
            LEFTPICTURE2:
                PRINT(); PRINT(tab: true); PRINT(Strings.Left.LeftPicture2Top);
                PRINT(tab: true); PRINT(Strings.Left.LeftPicture2L1);
                PRINT(tab: true); PRINT(Strings.Left.LeftPicture2L2);
                PRINT(tab: true); PRINT(Strings.Left.LeftPicture2L3);
                PRINT(tab: true); PRINT(Strings.Left.LeftPicture2L4);
                PRINT(tab: true); PRINT(Strings.Left.LeftPicture2L5);
            LEFTCHOICES:
                PRINT(); PRINT(tab: true); PRINT(Strings.Left.Whatwillyoudo);
                PRINT(tab: true); PRINT(Strings.Left.c1Giveupandgohome);
                PRINT(tab: true); PRINT(Strings.Left.c2Continueondownthepath);
                PRINT(tab: true); PRINT(Strings.Left.c3Gobacktothesignattheforkintheroad);
                if (PS != 1 && SW != 1) PRINT(tab: true); PRINT(Strings.Left.c4Gobacktothesignattheforkintheroad);
                if (PS == 1 && SW != 1) PRINT(tab: true); PRINT(Strings.Left.c4bGobacktothesignattheforkintheroadAgain);
                if (GB == 1 && SW != 1) PRINT(tab: true); PRINT(Strings.Left.c5Gobacktothesignattheforkintheroad);
                SCOREPRINT();
            CHOICE2:
                var EṨ = INKEYṨ();
                var E = VAL(EṨ);
                if (E == 5 && GB == 1 && SW != 1) { ROCKGOBOOM(); goto LEFT; }
                if (E == 4 && SW != 1) { PULLSWORD(); goto LEFT; }
                switch (E)
                {
                    case 1:
                        if (WIMPEND()) goto END;
                        goto GAME;
                    case 2:
                        goto SNAKEHOLE;
                    case 3:
                        goto FORK;
                    default:
                        goto CHOICE2;
                }
            RIGHT:
                CLS();
                PRINT(); PRINT(); PRINT(tab: true); PRINT(Strings.Right.YouarestandingbesideabombshopThedirt);
                PRINT(tab: true); PRINT(Strings.Right.paththatyouareonleadstoacliffahead);
                PRINT(tab: true); PRINT(Strings.Right.Youcanseetheforkintheroadwiththesign);
                PRINT(tab: true); PRINT(Strings.Right.behindyou);
                PRINT(); PRINT(tab: true); PRINT(Strings.Right.TopOfBombShop);
                PRINT(tab: true); PRINT(Strings.Right.BombShopL1);
                PRINT(tab: true); PRINT(Strings.Right.BombShopL2);
                PRINT(tab: true); PRINT(Strings.Right.BombShopL3);
                PRINT(tab: true); PRINT(Strings.Right.BombShopL4);
                PRINT(tab: true); PRINT(Strings.Right.BombShopL5);
                PRINT(tab: true); PRINT(Strings.Right.BombShopL6);
                PRINT(); PRINT(tab: true); PRINT(Strings.Right.Whatwillyoudo);
                PRINT(); PRINT(tab: true); PRINT(Strings.Right.c1Giveupandgohome);
                PRINT(tab: true); PRINT(Strings.Right.c2Walktothecliff);
                PRINT(tab: true); PRINT(Strings.Right.c3Gotothesignattheforkintheroad);
                if (GB != 1) { PRINT(tab: true); PRINT(Strings.Right.c4Buybombsattheshopwithmoney); }
                SCOREPRINT();
            CHOICE3:
                var FṨ = INKEYṨ();
                var F = VAL(FṨ);
                if (F == 4 && GB != 1) { BUYBOMBS(); goto RIGHT; }
                switch (F)
                {
                    case 1:
                        if (WIMPEND()) goto END;
                        goto GAME;
                    case 2:
                        goto CLIFF;
                    case 3:
                        goto FORK;
                    default:
                        goto CHOICE3;
                }
            CLIFF:
            END:
        }

        private void LEFTPICTURE1()
        {
            PRINT(); PRINT(tab: true); PRINT(Strings.Left.LeftPicture1Top);
            PRINT(tab: true); PRINT(Strings.Left.LeftPicture1L1);
            PRINT(tab: true); PRINT(Strings.Left.LeftPicture1L2);
            PRINT(tab: true); PRINT(Strings.Left.LeftPicture1L3);
            PRINT(tab: true); PRINT(Strings.Left.LeftPicture1L4);
            PRINT(tab: true); PRINT(Strings.Left.LeftPicture1L5);
        }

        #region Shared Vars

        private int S;
        private int GB;
        private int SW;
        private int CLJ;
        private int GL;
        private int SH;
        private int PS;
        private int DR;
        private int MMD;

        #endregion

        #region Program Funcs

        private bool WARNING()
        {
            CLS();
            COLOR(20);
            LOCATE(10, 30);
            PRINT(Strings.Warning.WARNING);
            SLEEP(2);
            COLOR(4);
            PRINT(); PRINT(); PRINT(tab: true); PRINT(Strings.Warning.THISGAMEISMOSTLYATEXTGAMEYOUWILLBE);
            PRINT(tab: true); PRINT(Strings.Warning.REQUIREDTOUSEYOURIMAGINATIONFORACHANGE);
            PRINT(); PRINT(Strings.Warning.AREYOUSTILLALOYALKNIGHTANDWILLINGTOCONTINUEYORN);
            WARNINGCHOICE:
                var CṨ = INKEYṨ();
                CṨ = UCASEṨ(CṨ);
                switch (CṨ)
                {
                    case Strings.Warning.N:
                        COLOR(14);
                        PRINT(tab: true); PRINT(tab: true); PRINT(Strings.Warning.WIMP);
                        SLEEP(1);
                        EXITSCREEN();
                        return true;
                    case Strings.Warning.Y:
                        COLOR(14);
                        PRINT(tab: true); PRINT(tab: true); PRINT(Strings.Warning.GREAT);
                        SLEEP(1);
                        goto WARNINGOVER;
                    default:
                        goto WARNINGCHOICE;
                }
            WARNINGOVER:
            return false;
        }

        private bool INSTRUCTIONS()
        {
            CLS();
            COLOR(10);
            PRINT(); PRINT(); PRINT(tab: true); PRINT(Strings.Instructions.WELCOMETO);
            LOCATE(3, 26);
            COLOR(20);
            PRINT(Strings.Instructions.ACRAZYKNIGHT);
            COLOR(10);
            LOCATE(3, 40);
            PRINT(Strings.Instructions.EXCLAMATIONS);
            PRINT(); PRINT(Strings.Instructions.CONGRATULATATIONSYOUHAVEBEENCALLEDUPONBYHISEXCELLENCY);
            COLOR(9);
            PRINT(); PRINT(tab: true); PRINT(tab: true); PRINT(Strings.Instructions.KINGARTHUR);
            COLOR(10);
            PRINT(); PRINT(Strings.Instructions.THEBEAUTIFULPRINCESSGWENDOLINHASBEENCAPTUREDBYTHEWICKEDWITCH);
            PRINT(Strings.Instructions.MADAMMAHEM);
            PRINT(tab: true); PRINT(Strings.Instructions.YOURJOBASTHEONLYKNIGHTLEFTISTOSAVETHEPRINCESSANDTHEKINGDOM);
            PRINT(Strings.Instructions.FROMTHECLUTCHESOFTHEEVILWITCHANDHERCRONIES);
            PRINT(); PRINT(tab: true); PRINT(Strings.Instructions.AREYOUCRAZYENOUGHTOTAKEUPTHECHALLENGEYORN);
            INSTRUCTIONSCHOICE:
                var BṨ = INKEYṨ();
                BṨ = UCASEṨ(BṨ);
                switch (BṨ)
                {
                    case Strings.Warning.N:
                        goto INSTRUCTIONS1;
                    case Strings.Warning.Y:
                        goto INSTRUCTIONS2;
                    default:
                        goto INSTRUCTIONSCHOICE;
                }
            INSTRUCTIONS1:
                COLOR(9);
                PRINT(); PRINT(tab: true); PRINT(Strings.Instructions.TOOBADIKNEWYOUWERENTBRAVEENOUGH);
                SLEEP(3);
                CLS();
                COLOR(14);
                LOCATE(10, 36);
                PRINT(Strings.Instructions.SEEYA);
                SLEEP(2);
                CLS();
                return true;
            INSTRUCTIONS2:
                COLOR(9);
                PRINT(); PRINT(tab: true); PRINT(Strings.Instructions.GREATGOFORTHTOSAVETHEPRINCESS);
                return false;
        }

        private void EXITSCREEN()
        {
            CLS();
            COLOR(14);
            LOCATE(10, 36);
            PRINT(Strings.Functions.SEEYA);
            SLEEP(2);
            CLS();
        }

        private void SPACEBAR()
        {
            LOCATE(23, 5);
            PRINT(Strings.Functions.PRESSSPACEBAR);
            INPUTSPACE:
            var SṨ = INKEYṨ();
            if (SṨ != " ") goto INPUTSPACE;
        }

        private bool WIMPEND()
        {
            CLS();
            COLOR(14);
            LOCATE(10, 37);
            PRINT(Strings.WimpEnd.YOUWIMP);
            SLEEP(2);
            CLS();
            LOCATE(7, 35);
            PRINT(Strings.WimpEnd.TOOBAD);
            SLEEP(3);
            LOCATE(10, 32);
            PRINT(Strings.WimpEnd.YOULOSE);
            SLEEP(3);
            FINALSCORE();
            SPACEBAR();
            return PLAYAGAIN();
        }

        private void FINALSCORE()
        {
            LOCATE(20, 14);
            PRINT(Strings.Functions.PtnFINALSCORE, false, S);
        }

        private bool PLAYAGAIN()
        {
            CLS();
            COLOR(14);
            LOCATE(10, 27);
            GB = 0;
            SW = 0;
            CLJ = 0;
            GL = 0;
            SH = 0;
            PS = 0;
            DR = 0;
            MMD = 0;
            PRINT(Strings.PlayAgain.DOYOUWANTTOPLAYAGAIN);
            CHOICEPLAYAGAIN:
                var PAṨ = INKEYṨ();
                PAṨ = UCASEṨ(PAṨ);
                switch (PAṨ)
                {
                    case Strings.PlayAgain.Y:
                        COLOR(9);
                        PRINT(); PRINT(tab: true); PRINT(Strings.PlayAgain.GREATGOFORTHTOSAVETHEPRINCESS);
                        SLEEP(2);
                        goto OVER;
                    case Strings.PlayAgain.N:
                        EXITSCREEN();
                        return true;
                    default:
                        goto CHOICEPLAYAGAIN;
                }
            OVER:
            return false;
        }

        private void SCOREPRINT()
        {
            LOCATE(23, 5);
            PRINT(Strings.Functions.PtnSCORE, false, S);
        }

        private void ROCKGOBOOM()
        {

        }

        private void PULLSWORD()
        {

        }

        private void BUYBOMBS()
        {

        }

        #endregion

        #region BASIC FNs

        private void SCREEN(int mode, int colorswitch = 0, int activePage = 0, int visualPage = 0)
        {
            _screen = SharedFunctions.Screen(0, 0);
        }

        private void COLOR(int color)
        {
            _screen.Color(color);
        }

        private void LOCATE(int row, int column)
        {
            _screen.Locate(row, column);
        }

        private void PRINT(string text = null, bool tab = false, params object[] vars)
        {
            if (vars.Any() && !string.IsNullOrWhiteSpace(text)) text = string.Format(text, vars);
            _screen.Print(text: text, tab: tab);
        }

        private void SLEEP(int seconds)
        {
            SharedFunctions.Sleep(seconds);
        }

        private string INKEYṨ()
        {
            return null;
        }

        private int VAL(string text)
        {
            return SharedFunctions.Val(text);
        }

        private void CLS()
        {
            _screen.CLS();
        }

        private void INPUT(string text, out string inputVar)
        {
            inputVar = _screen.Input(text);
        }

        public string UCASEṨ(string text)
        {
            return SharedFunctions.Ucase(text);
        }

        #endregion
    }
}
