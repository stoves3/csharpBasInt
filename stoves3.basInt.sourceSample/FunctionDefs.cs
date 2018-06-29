using System.Diagnostics.CodeAnalysis;
using System.Linq;
using stoves3.basInt.csharp.basFuncs;
using stoves3.basInt.csharp.core;
using stoves3.basInt.sourceSample.Sounds;
using stoves3.basInt.sourceSample.Strings;
#pragma warning disable 164

namespace stoves3.basInt.sourceSample
{
    [SuppressMessage("ReSharper", "InconsistentNaming")]
    [SuppressMessage("ReSharper", "RedundantArgumentDefaultValue")]
    [SuppressMessage("ReSharper", "RedundantJumpStatement")]
    public class FunctionDefs
    {
        private IScreen _screen;
        private readonly ISound _sound;
        private readonly IInput _input;
        
        #region Shared Vars

        private string NṨ;
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

        public FunctionDefs()
        {
            _input = new Keyboard();
            _sound = new Sound();
        }

        public void Run()
        {
            SCREEN(0, 0);
            COLOR(4);
            LOCATE(5, 28);
            PRINT(Intro.STEPHENMCKISICPRESENTS); SLEEP(1);
            COLOR(26);
            LOCATE(13, 32);
            PRINT(Intro.ACRAZYKNIGHT); SLEEP(4);

            MAINMENU();
            CHOICE:
                var AṨ = INKEYṨ();
                var A = VAL(AṨ);
                if (A == 1) { if (WARNING()) goto END; goto GAME; }
                if (A == 2) { if (INSTRUCTIONS()) goto END; }
                if (A == 2) { if (WARNING()) goto END; goto GAME; }
                if (A == 3) { if (EXITSCREEN()) goto END; goto END; }
                goto CHOICE;
            GAME:
            CLS();
            LOCATE(10, 20); COLOR(10);
            INPUT(Intro.WHATISYOURNAMEBRAVEKNIGHT, out NṨ);
            NṨ = UCASEṨ(NṨ);
            PRINT(); PRINT(tab: true); PRINT(tab: true); PRINT(Game.PtnWELCOMESIR, false, NṨ); SLEEP(2); COLOR(11); CLS();
            LOCATE(6, 8); PRINT(Game.PtnYOUBEINGCHOSENBYHISEXCELLENCYKINGARTHURHAVE, false, NṨ);
            LOCATE(8, 8); PRINT(Game.BEENGIVENSOMEMONEYANDNOTHINGMORETOGOOUTANDFINDTHE);
            LOCATE(10, 8); PRINT(Game.WITCHSCASTLEANDSAVETHEPRINCESSANYWEAPONSYOUMIGHTUSE);
            LOCATE(12, 8); PRINT(Game.AGAINSTTHEWITCHCANPROBABLYBEFOUNDALONGTHEWAY);
            PRINT(); PRINT(); PRINT(); PRINT(); PRINT(); PRINT(); PRINT(tab: true); PRINT(Game.PRESSSPACEBARTOBEGINYOURQUEST);
            COLOR(0);
            SPACEBAR();
            COLOR(11);
            S = 0;
            goto ALTFORK;
            FORK:
                CLS();
            ALTFORK:
                PRINT(); PRINT(); PRINT(tab: true); PRINT(Fork.YouarestandingoutsideofthecastlegateYouseea);
                PRINT(tab: true); PRINT(Fork.dirtpaththatgoestwodirectionsAsignispostedat);
                PRINT(tab: true); PRINT(Fork.theforkinthepaththatreads);
                PRINT(); PRINT(tab: true); PRINT(Fork.Bombshoptotheright);
                PRINT(tab: true); PRINT(Fork.Roadtowitchscastletotheleft);
                PRINT(tab: true); PRINT(Fork.TopOfForkRoadSign);
                PRINT(tab: true); PRINT(Fork.ForkRoadSignL1);
                PRINT(tab: true); PRINT(Fork.ForkRoadSignL2);
                PRINT(tab: true); PRINT(Fork.ForkRoadSignL3);
                PRINT(tab: true); PRINT(Fork.ForkRoadSignL4);
                PRINT(tab: true); PRINT(Fork.ForkRoadSignL5);
                PRINT(tab: true); PRINT(Fork.ForkRoadSignL6);
                PRINT(tab: true); PRINT(Fork.ForkRoadSignL7);
                PRINT(); PRINT(tab: true); PRINT(Fork.Whatwillyoudo);
                PRINT(); PRINT(tab: true); PRINT(Fork.c1Giveupandgohome);
                PRINT(tab: true); PRINT(Fork.c2Followthepathtotheright);
                PRINT(tab: true); PRINT(Fork.c3Followthepathtotheleft);
                PRINT(Fork.PtnSCORE, false, S);
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
            PRINT(); PRINT(); PRINT(tab: true); PRINT(Left.Youareonasmallweatherbeatenroadonthe);
            PRINT(tab: true); PRINT(Left.waytoMadamMahemscastleYoucanseethe);
            PRINT(tab: true); PRINT(Left.forkintheroadwiththesignbehindyou);
            if (SW != 1) { PRINT(tab: true); PRINT(Left.Youseeaswordembeddedinastonetothe); }
            if (SW != 1) { PRINT(tab: true); PRINT(Left.sideoftheroad); }
            if (SW != 1) { LEFTPICTURE1(); goto LEFTCHOICES; }
            goto LEFTPICTURE2;
            LEFTPICTURE2:
                PRINT(); PRINT(tab: true); PRINT(Left.LeftPicture2Top);
                PRINT(tab: true); PRINT(Left.LeftPicture2L1);
                PRINT(tab: true); PRINT(Left.LeftPicture2L2);
                PRINT(tab: true); PRINT(Left.LeftPicture2L3);
                PRINT(tab: true); PRINT(Left.LeftPicture2L4);
                PRINT(tab: true); PRINT(Left.LeftPicture2L5);
            LEFTCHOICES:
                PRINT(); PRINT(tab: true); PRINT(Left.Whatwillyoudo);
                PRINT(tab: true); PRINT(Left.c1Giveupandgohome);
                PRINT(tab: true); PRINT(Left.c2Continueondownthepath);
                PRINT(tab: true); PRINT(Left.c3Gobacktothesignattheforkintheroad);
                if (PS != 1 && SW != 1) { PRINT(tab: true); PRINT(Left.c4Gobacktothesignattheforkintheroad); }
                if (PS == 1 && SW != 1) { PRINT(tab: true); PRINT(Left.c4bGobacktothesignattheforkintheroadAgain); }
                if (GB == 1 && SW != 1) { PRINT(tab: true); PRINT(Left.c5Gobacktothesignattheforkintheroad); }
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
                PRINT(); PRINT(); PRINT(tab: true); PRINT(Right.YouarestandingbesideabombshopThedirt);
                PRINT(tab: true); PRINT(Right.paththatyouareonleadstoacliffahead);
                PRINT(tab: true); PRINT(Right.Youcanseetheforkintheroadwiththesign);
                PRINT(tab: true); PRINT(Right.behindyou);
                PRINT(); PRINT(tab: true); PRINT(Right.TopOfBombShop);
                PRINT(tab: true); PRINT(Right.BombShopL1);
                PRINT(tab: true); PRINT(Right.BombShopL2);
                PRINT(tab: true); PRINT(Right.BombShopL3);
                PRINT(tab: true); PRINT(Right.BombShopL4);
                PRINT(tab: true); PRINT(Right.BombShopL5);
                PRINT(tab: true); PRINT(Right.BombShopL6);
                PRINT(); PRINT(tab: true); PRINT(Right.Whatwillyoudo);
                PRINT(); PRINT(tab: true); PRINT(Right.c1Giveupandgohome);
                PRINT(tab: true); PRINT(Right.c2Walktothecliff);
                PRINT(tab: true); PRINT(Right.c3Gotothesignattheforkintheroad);
                if (GB != 1) { PRINT(tab: true); PRINT(Right.c4Buybombsattheshopwithmoney); }
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
                CLS();
                PRINT(); PRINT(tab: true); PRINT(Cliff.YouarestandingattheedgeofacliffThepath);
                PRINT(tab: true); PRINT(Cliff.leadsofftotheleftandbehindyoutoabombshop);
                if (CLJ != 1) { PRINT(tab: true); PRINT(Cliff.Youseeasignattheedgeofthecliffthatreads); }
                if (CLJ != 1) { PRINT(tab: true); PRINT(Cliff.JumpIdareyou); }
                if (CLJ != 1) { CLIFFPICTURE1(); goto CHOICES4; }
                CLIFFPICTURE2(); goto CHOICES4;
            CHOICES4:
                PRINT(); PRINT(tab: true); PRINT(Cliff.Whatwillyoudo);
                PRINT(); PRINT(tab: true); PRINT(Cliff.c1Giveupandgohome);
                PRINT(tab: true); PRINT(Cliff.c2Followthepathtotheleft);
                PRINT(tab: true); PRINT(Cliff.c3Followthepathtothebombshop);
                PRINT(tab: true); PRINT(Cliff.c4Yell);
                if (CLJ != 1) { PRINT(tab: true); PRINT(Cliff.c5Jumpoffthecliff); }
                SCOREPRINT();
            CHOICE4:
                var GṨ = INKEYṨ();
                var G = VAL(GṨ);
                if (CLJ != 1 && G == 5) { JUMPOFFCLIFF(); goto CLIFF; }
                switch (G)
                {
                    case 1:
                        if (WIMPEND()) goto END;
                        goto GAME;
                    case 2:
                        goto SNAKEHOLE;
                    case 3:
                        goto RIGHT;
                    case 4:
                        YELL();
                        goto CLIFF;
                    default:
                        goto CHOICE4;
                }
            SNAKEHOLE:
                CLS();
            SNAKEHOLEALT:
                PRINT(); PRINT(tab: true); PRINT(Snakehole.YouareatanintersectioninthepathThereisa);
                PRINT(tab: true); PRINT(Snakehole.conspicuouslookingholetothesideUpthepath);
                PRINT(tab: true); PRINT(Snakehole.youcanmakeoutthewitchscastleOvertothe);
                PRINT(tab: true); PRINT(Snakehole.rightyoucanseeacliffwithasignatitsedge);
                if (SW != 1) { PRINT(tab: true); PRINT(Snakehole.Behindyouisaswordinastone); }
                if (SW == 1) { PRINT(tab: true); PRINT(Snakehole.Youcanseethepathbehindyouwheretheswordin); }
                if (SW == 1) { PRINT(tab: true); PRINT(Snakehole.thestoneusedtobe); }
                PRINT(); PRINT(tab: true); PRINT(Snakehole.SnakeholePictureTop);
                PRINT(tab: true); PRINT(Snakehole.SnakeholePictureL1);
                PRINT(tab: true); PRINT(Snakehole.SnakeholePictureL2);
                PRINT(tab: true); PRINT(Snakehole.SnakeholePictureL3);
                PRINT(tab: true); PRINT(Snakehole.SnakeholePictureL4);
                PRINT(); PRINT(tab: true); PRINT(Snakehole.Whatwillyoudo);
                PRINT(); PRINT(tab: true); PRINT(Snakehole.c1Giveupandgohome);
                PRINT(tab: true); PRINT(Snakehole.c2Continueontothewitchscastle);
                PRINT(tab: true); PRINT(Snakehole.c3Followthepathtotheright);
                if (SW != 1) { PRINT(tab: true); PRINT(Snakehole.c4Gototheswordinthestonebehindyou); }
                if (SW == 1) { PRINT(tab: true); PRINT(Snakehole.c4bGobacktowheretheswordinthestoneusedtobe); }
                if (GL != 1) { PRINT(tab: true); PRINT(Snakehole.c5Stickyourheadinthehole); }
                if (GL != 1 && CLJ == 1 && SH != 1) { PRINT(tab: true); PRINT(Snakehole.c6PourSNAKEBEGONEdownthehole); }
                SCOREPRINT();
            CHOICE5:
                var HṨ = INKEYṨ();
                var H = VAL(HṨ);
                if (H == 5 && SH != 1) if (SNAKEHOLEDIE()) goto END;
                if (H == 5 && SH != 1) goto GAME;
                if (H == 5 && SH == 1 && GL != 1) { GETLAMP(); goto SNAKEHOLEALT; }
                if (H == 6 && CLJ == 1 && SH != 1) { POUROUTBOTTLE(); goto SNAKEHOLEALT; }
                switch (H)
                {
                    case 1:
                        if (WIMPEND()) goto END;
                        goto GAME;
                    case 2:
                        goto OUTSIDECASTLE;
                    case 3:
                        goto CLIFF;
                    case 4:
                        goto LEFT;
                    default:
                        goto CHOICE5;
                }
            OUTSIDECASTLE:
                CLS();
            OUTSIDECASTLEALT:
                PRINT(tab: true); PRINT(OutsideCastle.YouhavearrivedatMadamMahemscastleAmoatsurrounds);
                PRINT(tab: true); PRINT(OutsideCastle.thefortressandahugedarkcloudloomsoverheadYoucan);
                PRINT(tab: true); PRINT(OutsideCastle.hearacryforhelpcomingfromthesingleforbodingtower);
                if (DR != 1) { PRINT(tab: true); PRINT(OutsideCastle.Unfortunatelythedrawbridgeisup); }
                if (DR == 1) { PRINT(tab: true); PRINT(OutsideCastle.Thedrawbridgeisdown); }
                if (DR != 1) { CASTLEPICTURE1(); goto CHOICES6; }
                CASTLEPICTURE2(); goto CHOICES6;
            CHOICES6:
                PRINT(tab: true); PRINT(OutsideCastle.Whatareyougoingtodo);
                PRINT(tab: true); PRINT(OutsideCastle.c1Giveupandgohome);
                PRINT(tab: true); PRINT(OutsideCastle.c3Gobacktotheintersectionwiththeholebehindyou);
                if (GL == 1 && DR != 1) { PRINT(tab: true); PRINT(OutsideCastle.c4Trytorubyourlamp); }
                if (GL == 1 && DR != 1) { PRINT(tab: true); PRINT(OutsideCastle.c5Drinkthestuffthatsinthelamp); }
                if (DR == 1) { PRINT(tab: true); PRINT(OutsideCastle.c4bEnterthecastle); }
                SCOREPRINT();
            CHOICE6:
                var IṨ = INKEYṨ();
                var I = VAL(IṨ);
                if (I == 4 && GL == 1 && DR != 1) { TRYTORUBLAMP(); goto OUTSIDECASTLE; }
                if (I == 5 && GL == 1 && DR != 1) { GETSTRONG(); goto OUTSIDECASTLEALT; }
                if (I == 4 && DR == 1 && MMD != 1) goto INSIDECASTLE;
                if (I == 4 && DR == 1 && MMD == 1) goto ATPRINCESS;
                switch (I)
                {
                    case 1:
                        if (WIMPEND()) goto END;
                        goto GAME;
                    case 2:
                        if (MOATDIE()) goto END;
                        goto GAME;
                    case 3:
                        goto SNAKEHOLE;
                    default:
                        goto CHOICE6;
                }
            INSIDECASTLE:
                CLS();
                PRINT(); PRINT(); PRINT(tab: true); PRINT(InsideCastle.Yourushintothecastleandupthetowerstairs);
                PRINT(tab: true); PRINT(InsideCastle.AsyoureachthetopofthetoweryouseeMadam);
                PRINT(tab: true); PRINT(InsideCastle.MahemherselfflyingstraightatyouYouhave);
                PRINT(tab: true); PRINT(InsideCastle.timetodoonlyonething);
                PRINT(tab: true); PRINT(InsideCastle.THISISTHEMOMENTOFTRUTH);
                PRINT(); PRINT(tab: true); PRINT(InsideCastle.WitchPictureTop);
                PRINT(tab: true); PRINT(InsideCastle.WitchPictureL1);
                PRINT(tab: true); PRINT(InsideCastle.WitchPictureL2);
                PRINT(tab: true); PRINT(InsideCastle.WitchPictureL3);
                PRINT(tab: true); PRINT(InsideCastle.WitchPictureL4);
                PRINT(tab: true); PRINT(InsideCastle.WitchPictureL5);
                PRINT(tab: true); PRINT(InsideCastle.WitchPictureL6);
                PRINT(tab: true); PRINT(InsideCastle.WitchPictureL7);
                PRINT(tab: true); PRINT(InsideCastle.WitchPictureL8);
                PRINT(); PRINT(tab: true); PRINT(InsideCastle.Whatareyougoingtodo);
                PRINT(tab: true); PRINT(InsideCastle.c1Runbackoutofthecastle);
                PRINT(tab: true); PRINT(InsideCastle.c2Duck);
                if (SW == 1) { PRINT(tab: true); PRINT(InsideCastle.c3Trytocutthebroominhalfasthewitchflysby); }
                SCOREPRINT();
            CHOICE7:
                var JṨ = INKEYṨ();
                var J = VAL(JṨ);
                if (J == 3 && SW == 1) if (TURNEDTOFROG()) goto END;
                if (J == 3 && SW == 1) goto GAME;
                switch (J)
                {
                    case 1:
                        goto OUTSIDECASTLE;
                    case 2:
                        KNOCKOUTWITCH();
                        goto ATPRINCESS;
                    default:
                        goto CHOICE7;
                }
            ATPRINCESS:
                CLS();
                PRINT(); PRINT(); PRINT(tab: true); PRINT(AtPrincess.BehindtheknockeddownwallyouseePrincessGwendolin);
                PRINT(tab: true); PRINT(AtPrincess.tiedtoachairandscreamingforhelpImmediatelyyou);
                PRINT(tab: true); PRINT(AtPrincess.rushtoherside);
                PRINT(tab: true); PRINT(AtPrincess.PrincessPictureTop);
                PRINT(tab: true); PRINT(AtPrincess.PrincessPictureL1);
                PRINT(tab: true); PRINT(AtPrincess.PrincessPictureL2);
                PRINT(tab: true); PRINT(AtPrincess.PrincessPictureL3);
                PRINT(tab: true); PRINT(AtPrincess.PrincessPictureL4);
                PRINT(tab: true); PRINT(AtPrincess.PrincessPictureL5);
                PRINT(tab: true); PRINT(AtPrincess.PrincessPictureL6);
                PRINT(tab: true); PRINT(AtPrincess.PrincessPictureL7);
                PRINT(tab: true); PRINT(AtPrincess.PrincessPictureL8);
                PRINT(tab: true); PRINT(AtPrincess.PrincessPictureL9);
                PRINT(tab: true); PRINT(AtPrincess.PrincessPictureL10);
                PRINT(tab: true); PRINT(AtPrincess.Whatareyougoingtodo);
                PRINT(); PRINT(tab: true); PRINT(AtPrincess.c1Runbackoutofthecastle);
                PRINT(tab: true); PRINT(AtPrincess.c2Trytountieher);
                PRINT(tab: true); PRINT(AtPrincess.c3Giveherakiss);
                if (SW == 1) { PRINT(tab: true); PRINT(AtPrincess.c4Cuttheropeswithyoursword); }
                SCOREPRINT();
            CHOICE8:
                var KṨ = INKEYṨ();
                var K = VAL(KṨ);
                if (K == 4 && SW == 1) CUTPRINCESSFREE();
                if (K == 4 && SW == 1) { WINGAME(); goto END; }
                switch (K)
                {
                    case 1:
                        LEAVEPRINCESS();
                        goto OUTSIDECASTLE;
                    case 2:
                        TRYUNTIE();
                        goto ATPRINCESS;
                    case 3:
                        if (KISSDIE()) goto END;
                        goto GAME;
                    default:
                        goto CHOICE8;
                }

            END:
            ;
        }

        private void LEFTPICTURE1()
        {
            PRINT(); PRINT(tab: true); PRINT(Left.LeftPicture1Top);
            PRINT(tab: true); PRINT(Left.LeftPicture1L1);
            PRINT(tab: true); PRINT(Left.LeftPicture1L2);
            PRINT(tab: true); PRINT(Left.LeftPicture1L3);
            PRINT(tab: true); PRINT(Left.LeftPicture1L4);
            PRINT(tab: true); PRINT(Left.LeftPicture1L5);
        }

        private void CASTLEPICTURE1()
        {
            PRINT(tab: true); PRINT(OutsideCastle.CastlePicture1Top);
            PRINT(tab: true); PRINT(OutsideCastle.CastlePicture1L1);
            PRINT(tab: true); PRINT(OutsideCastle.CastlePicture1L2);
            PRINT(tab: true); PRINT(OutsideCastle.CastlePicture1L3);
            PRINT(tab: true); PRINT(OutsideCastle.CastlePicture1L4);
            PRINT(tab: true); PRINT(OutsideCastle.CastlePicture1L5);
            PRINT(tab: true); PRINT(OutsideCastle.CastlePicture1L6);
            PRINT(tab: true); PRINT(OutsideCastle.CastlePicture1L7);
            PRINT(tab: true); PRINT(OutsideCastle.CastlePicture1L8);
            PRINT(tab: true); PRINT(OutsideCastle.CastlePicture1L9);
            PRINT(tab: true); PRINT(OutsideCastle.CastlePicture1L10);
            PRINT(tab: true); PRINT(OutsideCastle.CastlePicture1L11);
        }

        private void CASTLEPICTURE2()
        {
            PRINT(tab: true); PRINT(OutsideCastle.CastlePicture2Top);
            PRINT(tab: true); PRINT(OutsideCastle.CastlePicture2L1);
            PRINT(tab: true); PRINT(OutsideCastle.CastlePicture2L2);
            PRINT(tab: true); PRINT(OutsideCastle.CastlePicture2L3);
            PRINT(tab: true); PRINT(OutsideCastle.CastlePicture2L4);
            PRINT(tab: true); PRINT(OutsideCastle.CastlePicture2L5);
            PRINT(tab: true); PRINT(OutsideCastle.CastlePicture2L6);
            PRINT(tab: true); PRINT(OutsideCastle.CastlePicture2L7);
            PRINT(tab: true); PRINT(OutsideCastle.CastlePicture2L8);
            PRINT(tab: true); PRINT(OutsideCastle.CastlePicture2L9);
            PRINT(tab: true); PRINT(OutsideCastle.CastlePicture2L10);
            PRINT(tab: true); PRINT(OutsideCastle.CastlePicture2L11);
        }

        private void CLIFFPICTURE1()
        {
            PRINT();
            PRINT(tab: true); PRINT(Cliff.CliffPictureTop);
            PRINT(tab: true); PRINT(Cliff.CliffPictureL1);
            PRINT(tab: true); PRINT(Cliff.CliffPictureL2);
            PRINT(tab: true); PRINT(Cliff.CliffPictureL3);
            PRINT(tab: true); PRINT(Cliff.CliffPictureL4);
            PRINT(tab: true); PRINT(Cliff.CliffPictureL5);
            PRINT(tab: true); PRINT(Cliff.CliffPictureL6);
            PRINT(tab: true); PRINT(Cliff.CliffPictureL7);
        }

        private void CLIFFPICTURE2()
        {
            PRINT(); PRINT(); PRINT();
            PRINT(tab: true); PRINT(Cliff.CliffPicture2L1);
            PRINT(tab: true); PRINT(Cliff.CliffPicture2L2);
            PRINT(tab: true); PRINT(Cliff.CliffPicture2L3);
            PRINT(tab: true); PRINT(Cliff.CliffPicture2L4);
            PRINT(tab: true); PRINT(Cliff.CliffPicture2L5);
        }

        #region Program Funcs

        private void MAINMENU()
        {
            CLS();
            COLOR(9);
            LOCATE(5, 30);
            PRINT(MainMenu.MENU);
            LOCATE(6, 30);
            PRINT(MainMenu.Line);
            LOCATE(10, 27);
            PRINT(MainMenu.c1PLAYGAME);
            LOCATE(13, 27);
            PRINT(MainMenu.c2INSTRUCTIONS);
            LOCATE(16, 27);
            PRINT(MainMenu.c3EXITPROGRAM);
        }

        private bool WARNING()
        {
            CLS();
            COLOR(20);
            LOCATE(10, 30);
            PRINT(Warning.WARNING);
            SLEEP(2);
            COLOR(4);
            PRINT(); PRINT(); PRINT(tab: true); PRINT(Warning.THISGAMEISMOSTLYATEXTGAMEYOUWILLBE);
            PRINT(tab: true); PRINT(Warning.REQUIREDTOUSEYOURIMAGINATIONFORACHANGE);
            PRINT(); PRINT(Warning.AREYOUSTILLALOYALKNIGHTANDWILLINGTOCONTINUEYORN);
            WARNINGCHOICE:
                var CṨ = INKEYṨ();
                CṨ = UCASEṨ(CṨ);
                switch (CṨ)
                {
                    case Warning.N:
                        COLOR(14);
                        PRINT(tab: true); PRINT(tab: true); PRINT(Warning.WIMP);
                        SLEEP(1);
                        if (EXITSCREEN()) return true;
                        return true;
                    case Warning.Y:
                        COLOR(14);
                        PRINT(tab: true); PRINT(tab: true); PRINT(Warning.GREAT);
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
            PRINT(); PRINT(); PRINT(tab: true); PRINT(Instructions.WELCOMETO);
            LOCATE(3, 26);
            COLOR(20);
            PRINT(Instructions.ACRAZYKNIGHT);
            COLOR(10);
            LOCATE(3, 40);
            PRINT(Instructions.EXCLAMATIONS);
            PRINT(); PRINT(Instructions.CONGRATULATATIONSYOUHAVEBEENCALLEDUPONBYHISEXCELLENCY);
            COLOR(9);
            PRINT(); PRINT(tab: true); PRINT(tab: true); PRINT(Instructions.KINGARTHUR);
            COLOR(10);
            PRINT(); PRINT(Instructions.THEBEAUTIFULPRINCESSGWENDOLINHASBEENCAPTUREDBYTHEWICKEDWITCH);
            PRINT(Instructions.MADAMMAHEM);
            PRINT(tab: true); PRINT(Instructions.YOURJOBASTHEONLYKNIGHTLEFTISTOSAVETHEPRINCESSANDTHEKINGDOM);
            PRINT(Instructions.FROMTHECLUTCHESOFTHEEVILWITCHANDHERCRONIES);
            PRINT(); PRINT(tab: true); PRINT(Instructions.AREYOUCRAZYENOUGHTOTAKEUPTHECHALLENGEYORN);
            INSTRUCTIONSCHOICE:
                var BṨ = INKEYṨ();
                BṨ = UCASEṨ(BṨ);
                switch (BṨ)
                {
                    case Warning.N:
                        goto INSTRUCTIONS1;
                    case Warning.Y:
                        goto INSTRUCTIONS2;
                    default:
                        goto INSTRUCTIONSCHOICE;
                }
            INSTRUCTIONS1:
                COLOR(9);
                PRINT(); PRINT(tab: true); PRINT(Instructions.TOOBADIKNEWYOUWERENTBRAVEENOUGH);
                SLEEP(3);
                CLS();
                COLOR(14);
                LOCATE(10, 36);
                PRINT(Instructions.SEEYA);
                SLEEP(2);
                CLS();
                return true;
            INSTRUCTIONS2:
                COLOR(9);
                PRINT(); PRINT(tab: true); PRINT(Instructions.GREATGOFORTHTOSAVETHEPRINCESS);
                SLEEP(3);
                return false;
        }

        private bool EXITSCREEN()
        {
            CLS();
            COLOR(14);
            LOCATE(10, 36);
            PRINT(Functions.SEEYA);
            SLEEP(2);
            CLS();
            return true;
        }

        private void SPACEBAR()
        {
            LOCATE(23, 5);
            PRINT(Functions.PRESSSPACEBAR);
            INPUTSPACE:
            var SṨ = INKEYṨ();
            if (SṨ != " ") goto INPUTSPACE;
        }

        private bool WIMPEND()
        {
            CLS();
            COLOR(14);
            LOCATE(10, 37);
            PRINT(WimpEnd.YOUWIMP);
            SLEEP(2);
            CLS();
            LOCATE(7, 35);
            PRINT(WimpEnd.TOOBAD);
            SLEEP(3);
            LOCATE(10, 32);
            PRINT(WimpEnd.YOULOSE);
            SLEEP(3);
            FINALSCORE();
            SPACEBAR();
            return PLAYAGAIN();
        }

        private void FINALSCORE()
        {
            LOCATE(20, 14);
            PRINT(Functions.PtnFINALSCORE, false, S);
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
            PRINT(PlayAgain.DOYOUWANTTOPLAYAGAIN);
            CHOICEPLAYAGAIN:
                var PAṨ = INKEYṨ();
                PAṨ = UCASEṨ(PAṨ);
                switch (PAṨ)
                {
                    case PlayAgain.Y:
                        COLOR(9);
                        PRINT(); PRINT(tab: true); PRINT(PlayAgain.GREATGOFORTHTOSAVETHEPRINCESS);
                        SLEEP(2);
                        goto OVER;
                    case PlayAgain.N:
                        if (EXITSCREEN()) return true;
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
            PRINT(Functions.PtnSCORE, false, S);
        }

        private void BUYBOMBS()
        {
            CLS();
            LOCATE(10, 30);
            PRINT(Buybombs.YOUGOTSOMEBOMBS);
            SLEEP(2);
            LOCATE(13, 35);
            PRINT(Buybombs.POINTS);
            GB = 1;
            S = S + 10;
            SPACEBAR();
            CLS();
        }

        private void CREDITS()
        {
            CLS();
            LOCATE(23, 34);
            COLOR(4);
            PRINT(Credits.CREDITS);
            PRINT(tab: true); PRINT(tab: true); PRINT(Credits.Line);
            COLOR(2);
            PAUSE1();
            PRINT(tab: true); PRINT(tab: true); PRINT(Credits.STORYWRITER);
            PAUSE2();
            PRINT(tab: true); PRINT(tab: true); PRINT(Credits.STEPHENMCKISIC);
            COLOR(3);
            PAUSE1();
            PRINT(tab: true); PRINT(tab: true); PRINT(Credits.PROGRAMMER);
            PAUSE2();
            PRINT(tab: true); PRINT(tab: true); PRINT(Credits.STEPHENMCKISIC);
            COLOR(1);
            PAUSE1();
            PRINT(tab: true); PRINT(tab: true); PRINT(Credits.GRAPHICSDESIGNER);
            PAUSE2();
            PRINT(tab: true); PRINT(tab: true); PRINT(Credits.STEPHENMCKISIC);
            COLOR(5);
            PAUSE1();
            PRINT(tab: true); PRINT(tab: true); PRINT(Credits.EDITOR);
            PAUSE2();
            PRINT(tab: true); PRINT(tab: true); PRINT(Credits.STEPHENMCKISIC);
            COLOR(14);
            PAUSE1();
            PRINT(tab: true); PRINT(tab: true); PRINT(Credits.SPECIALTHANKSTO);
            PAUSE2();
            PRINT(tab: true); PRINT(tab: true); PRINT(Credits.STEPHENMCKISIC);
            COLOR(10);
            PAUSE1();
            PRINT(tab: true); PRINT(tab: true); PRINT(Credits.EXECUTIVEPRODUCER);
            PAUSE2();
            PRINT(tab: true); PRINT(tab: true); PRINT(Credits.STEPHENMCKISIC);
            COLOR(13);
            PAUSE1();
            PRINT(tab: true); PRINT(tab: true); PRINT(Credits.Copyright1995SDMInc);
            PAUSE3();
            COLOR(15);
            PRINT(tab: true); PRINT(tab: true); PRINT(Credits.THEEND);
            PAUSE1(); PAUSE2(); PAUSE2(); PAUSE2();
            SLEEP(20);
            CLS();
        }

        private void PAUSE1()
        {
            PLAY(Pause.P8); PRINT(); PLAY(Pause.P8); PRINT(); PLAY(Pause.P8); PRINT(); PLAY(Pause.P8); PRINT();
            PLAY(Pause.P8); PRINT(); PLAY(Pause.P8); PRINT(); PLAY(Pause.P8); PRINT(); PLAY(Pause.P8); PRINT();
        }

        private void PAUSE2()
        {
            PLAY(Pause.P8); PRINT();
        }

        private void PAUSE3()
        {
            PLAY(Pause.P8); PRINT(); PLAY(Pause.P8); PRINT(); PLAY(Pause.P8); PRINT(); PLAY(Pause.P8); PRINT();
            PLAY(Pause.P8); PRINT(); PLAY(Pause.P8); PRINT(); PLAY(Pause.P8); PRINT(); PLAY(Pause.P8); PRINT();
            PLAY(Pause.P8); PRINT(); PLAY(Pause.P8); PRINT(); PLAY(Pause.P8); PRINT(); PLAY(Pause.P8); PRINT();
            PLAY(Pause.P8); PRINT(); PLAY(Pause.P8); PRINT(); PLAY(Pause.P8); PRINT(); PLAY(Pause.P8); PRINT();
        }

        private void ROCKGOBOOM()
        {
            CLS();
            COLOR(26);
            LOCATE(10, 34);
            PRINT(RockGoBoom.BOOM);
            SLEEP(3);
            CLS();
            LOCATE(10, 20);
            COLOR(11);
            PRINT(RockGoBoom.YOUBLEWUPTHEROCKANDGOTTHESWORD);
            SLEEP(2);
            LOCATE(13, 35);
            PRINT(RockGoBoom.POINTS);
            SW = 1;
            S = S + 10;
            SPACEBAR();
            CLS();
        }

        private void PULLSWORD()
        {
            CLS();
            LOCATE(10, 15);
            PRINT(PullSword.Thoughyoutryhardyoucantpulloutthesword);
            SLEEP(2);
            LOCATE(12, 19);
            PRINT(PullSword.FacethefactsYourejustaweakling);
            PS = 1;
            SPACEBAR();
            CLS();
        }

        private void JUMPOFFCLIFF()
        {
            CLS();
            LOCATE(8, 21);
            PRINT(JumpOffCliff.Wheredidyougetanidealikethat);
            LOCATE(9, 7);
            PRINT(JumpOffCliff.Fortunatelyforyoutheprogrammerofthisgameisaniceguy);
            SLEEP(3);
            LOCATE(11, 10);
            PRINT(JumpOffCliff.PUFFTHEMAGICDRAGONFLYSBYANDCATCHESYOUONHISBACK);
            SLEEP(2);
            LOCATE(13, 10);
            PRINT(JumpOffCliff.HESETSYOUBACKONTHECLIFFANDRIPSTHESIGNTOSHREDS);
            SLEEP(2);
            LOCATE(15, 10);
            PRINT(JumpOffCliff.THENHEGIVESYOUABOTTLEOFSNAKEBEGONEANDFLYSAWAY);
            SLEEP(2);
            LOCATE(17, 35);
            PRINT(JumpOffCliff.POINTS);
            SPACEBAR();
            CLJ = 1;
            S = S + 10;
            CLS();
        }

        private void YELL()
        {
            CLS();
            LOCATE(9, 14);
            PRINT(Yell.Youyellloudlybutallthatrespondsisyourecho);
            SLEEP(2);
            LOCATE(11, 28);
            PRINT(Yell.Boythatwaspointless);
            SPACEBAR();
            CLS();
        }

        private bool SNAKEHOLEDIE()
        {
            CLS();
            LOCATE(8, 8);
            PRINT(SnakeholeDie.Youhavejuststuckyourheadintoaholefullofdeadlysnakes);
            SLEEP(2);
            LOCATE(10, 25);
            PRINT(SnakeholeDie.PtnEeeeeeewbadmove, false, NṨ);
            SLEEP(2);
            LOCATE(12, 11);
            PRINT(SnakeholeDie.Youdieaveryquickbutverypainfuldeathashundreds);
            LOCATE(13, 14);
            PRINT(SnakeholeDie.ofvenomoussnakessinktheirfangsintoyourface);
            SPACEBAR();
            return LOSE();
        }

        private bool LOSE()
        {
            CLS();
            COLOR(14);
            LOCATE(7, 35);
            PRINT(Lose.TOOBAD);
            SLEEP(3);
            LOCATE(10, 32);
            PRINT(Lose.YOULOSE);
            SLEEP(3);
            FINALSCORE();
            SPACEBAR();
            return PLAYAGAIN();
        }

        private void GETLAMP()
        {
            CLS();
            LOCATE(8, 9);
            PRINT(GetLamp.YOULOOKINTHEHOLEANDSEEHUNDREDSOFSHRIVELEDUPSNAKES);
            SLEEP(2);
            LOCATE(10, 3);
            PRINT(GetLamp.YOUNOTICEATTHEBACKOFTHEHOLEANOLDDUSTYOILLAMPWHICHYOUTAKE);
            SLEEP(2);
            LOCATE(12, 35);
            PRINT(GetLamp.POINTS);
            SPACEBAR();
            GL = 1;
            S = S + 20;
            CLS();
        }

        private void POUROUTBOTTLE()
        {
            CLS();
            LOCATE(8, 3);
            PRINT(PourOutBottle.ASYOUPOUROUTTHESNAKEBEGONEINTOTHEHOLEYOUHEARALOUDHISSCOMING);
            LOCATE(10, 33);
            PRINT(PourOutBottle.FROMTHEHOLE);
            SPACEBAR();
            SH = 1;
            CLS();
        }

        private void TRYTORUBLAMP()
        {
            CLS();
            LOCATE(7, 28);
            PRINT(TryToRubLamp.YourubthelampAND);
            SLEEP(3);
            LOCATE(9, 32);
            PRINT(TryToRubLamp.Nothinghappens);
            SLEEP(2);
            LOCATE(13, 28);
            PRINT(TryToRubLamp.Whatdidyouexpect);
            SLEEP(1);
            LOCATE(15, 35);
            PRINT(TryToRubLamp.agenie);
            SLEEP(1);
            LOCATE(17, 28);
            PRINT(TryToRubLamp.Hahahahahaha);
            SPACEBAR();
            CLS();
        }

        private void GETSTRONG()
        {
            CLS();
            LOCATE(6, 5);
            PRINT(GetStrong.ASYOUDRINKTHELIQUIDFROMTHELAMPYOUBECOMEINCREDIBLYSTRONG);
            SLEEP(2);
            LOCATE(8, 13);
            PRINT(GetStrong.YOULEAPACROSSTHEMOATANDPULLDOWNTHEDRAWBRIDGE);
            SLEEP(2);
            LOCATE(10, 15);
            PRINT(GetStrong.UNFORTUNATELYYOUUSEUPALLYOUREXTRASTRENGTH);
            LOCATE(12, 24);
            PRINT(GetStrong.BUTATLEASTTHEBRIDGEISDOWN);
            SLEEP(2);
            LOCATE(14, 35);
            PRINT(GetStrong.POINTS);
            SLEEP(2);
            DR = 1;
            S = S + 10;
            SPACEBAR();
            CLS();
        }

        private bool MOATDIE()
        {
            CLS();
            LOCATE(8, 9);
            PRINT(MoatDie.Asyoudiveintothemoatyourealizeyouaresurroundedby);
            SLEEP(2);
            LOCATE(10, 28);
            PRINT(MoatDie.MANEATINGCROCODILES);
            SLEEP(2);
            LOCATE(12, 27);
            PRINT(MoatDie.Lookslikethisistheend);
            SPACEBAR();
            return LOSE();
        }

        private bool TURNEDTOFROG()
        {
            CLS();
            LOCATE(8, 9);
            PRINT(TurnedToFrog.Youattempttocutthebroominhalfasthwitchflysbybut);
            LOCATE(10, 17);
            PRINT(TurnedToFrog.youmissandthewitchturnsyouintoatoad);
            SLEEP(3);
            LOCATE(12, 31);
            PRINT(TurnedToFrog.HaveaHOPPYlife);
            SPACEBAR();
            return LOSE();
        }

        private void KNOCKOUTWITCH()
        {
            CLS();
            LOCATE(8, 7);
            PRINT(KnockOutWitch.YOUDUCKANDSINCEMADAMMAHEMHASONLYHADHERBROOMFORAWEEK);
            LOCATE(10, 8);
            PRINT(KnockOutWitch.SHELOSESCONTROLANDCAREENSOVERYOURHEADTHENSHECLUMSILY);
            LOCATE(12, 9);
            PRINT(KnockOutWitch.SLAMSINTOTHEWALLKNOCKINGHERSELFOUTANDTHEWALLDOWN);
            LOCATE(14, 24);
            PRINT(KnockOutWitch.YOUHAVEDEFEATEDMADAMMAHEM);
            SLEEP(5);
            LOCATE(16, 35);
            PRINT(KnockOutWitch.POINTS);
            MMD = 1;
            S = S + 50;
            SPACEBAR();
            CLS();
        }

        private void CUTPRINCESSFREE()
        {
            CLS();
            LOCATE(9, 15);
            PRINT(CutPrincessFree.YOUKNEWTHEREWASAREASONFORGETTINGTHISSWORD);
            LOCATE(11, 20);
            PRINT(CutPrincessFree.YOUCAREFULLYCUTPRINCESSGWENDOLINFREE);
            SLEEP(3);
            LOCATE(13, 35);
            PRINT(CutPrincessFree.POINTS);
            S = S + 100;
            SPACEBAR();
        }

        private void WINGAME()
        {
            CLS();
            COLOR(26);
            LOCATE(5, 30);
            PRINT(WinGame.CONGRATULATIONS);
            COLOR(14);
            LOCATE(8);
            PRINT(tab: true); PRINT(WinGame.YOUHAVESAVEDTHEPRINCESSANDTHEKINGDOMFROMMADAMMAHEM);
            PRINT(tab: true); PRINT(WinGame.KINGARTHURANDHISSUBJECTSTHANKYOUHEARTILYANDCELEBRATE);
            PRINT(tab: true); PRINT(WinGame.YOURVICTORYWITHAHUGEFESTIVALYOUAREGIVENAHIGHRANK);
            PRINT(tab: true); PRINT(WinGame.INTHEKINGSARMYANDASINALLGOODFAIRYTALES);
            PRINT(); PRINT(tab: true); PRINT(WinGame.EVERYONELIVESHAPPILYEVERAFTER);
            FINALSCORE();
            MUSIC();
            SPACEBAR();
            CLS();
            CREDITS();
        }

        private void MUSIC()
        {
            PLAY(Music.Tune);
        }

        private void LEAVEPRINCESS()
        {
            CLS();
            LOCATE(9, 10);
            PRINT(LeavePrincess.Asyourunofftheprincessstaresatyouwithindignation);
            LOCATE(11, 18);
            PRINT(LeavePrincess.andthensheresumesherscreamingforhelp);
            SLEEP(3);
            SPACEBAR();
        }

        private void TRYUNTIE()
        {
            CLS();
            LOCATE(9, 16);
            PRINT(TryUntie.Youtryhardtountietheropesbutyoucant);
            SLEEP(2);
            LOCATE(11, 17);
            PRINT(TryUntie.Facethefactsyouarejustabigweakling);
            SLEEP(1);
            SPACEBAR();
        }

        private bool KISSDIE()
        {
            CLS();
            LOCATE(6, 17);
            PRINT(KissDie.HeyWaitaminuteYoushouldknowbetter);
            LOCATE(8, 22);
            PRINT(KissDie.ThisgamewaswrittenatBobJones);
            SLEEP(3);
            LOCATE(10, 9);
            PRINT(KissDie.TheinfuriatedPrincessGwendolinsnapstheropesandslapsyou);
            LOCATE(12, 7);
            PRINT(KissDie.acrossthefacesendingyouflyingbackwardsoutthetowerwindow);
            SLEEP(3);
            LOCATE(14, 5);
            PRINT(KissDie.Youfallintothemoatwherethemaneatingcrocodilesarewaiting);
            SLEEP(1);
            SPACEBAR();
            return LOSE();
        }

        #endregion

        #region BASIC FNs

        private void SCREEN(int mode, int colorswitch = 0, int activePage = 0, int visualPage = 0)
        {
            _screen = SharedFunctions.Screen(mode, colorswitch, activePage, visualPage);
        }

        private void COLOR(int color)
        {
            _screen.Color(color);
        }

        private void LOCATE(int row, int column = 1)
        {
            _screen.Locate(row, column);
        }

        private void PRINT(string text = null, bool tab = false, params object[] vars)
        {
            if (vars.Any() && !string.IsNullOrWhiteSpace(text)) text = string.Format(text, vars);
            _screen.Print(text: text, tab: tab);
        }

        private string INKEYṨ()
        {
            return _screen.INKEYṨ(_input);
        }

        private void CLS()
        {
            _screen.CLS();
        }

        private void INPUT(string text, out string inputVar)
        {
            inputVar = _screen.Input(_input, text);
        }

        private void PLAY(string musicString)
        {
            _sound.Play(musicString);
        }

        private void SLEEP(int seconds)
        {
            SharedFunctions.Sleep(seconds);
        }

        private int VAL(string text)
        {
            return SharedFunctions.Val(text);
        }

        private string UCASEṨ(string text)
        {
            return SharedFunctions.Ucase(text);
        }

        #endregion
    }
}
