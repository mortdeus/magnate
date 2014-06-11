// AUTOMATICALLY GENERATED CODE

using System;
using System.Collections.Generic;
using Sce.Pss.Core;
using Sce.Pss.Core.Imaging;
using Sce.Pss.Core.Environment;
using Sce.Pss.HighLevel.UI;

namespace MagnateUI
{
    partial class BattleUI
    {
        ImageBox BackgroundOverlay;
        ImageBox EnemyFrame1;
        ImageBox EnemyFrame2;
        ImageBox EnemyFrame3;
        ImageBox btnHero1Skilltop;
        ImageBox btnHero1Skillleft;
        ImageBox btnHero1Skillright;
        ImageBox btnHero2Skilltop;
        ImageBox btnHero2Skillleft;
        ImageBox btnHero2Skillright;
        ImageBox EnemyPortrait1;
        ImageBox EnemyPortrait2;
        ImageBox EnemyPortrait3;
        ImageBox HeroPortrait1;
        ImageBox HeroPortrait2;
        ImageBox Background;
        ImageBox EnemyBody1;
        ImageBox EnemyBody2;
        ImageBox EnemyBody3;
        ImageBox Enemyhp1;
        ImageBox Enemyhp2;
        ImageBox Enemyhp3;
        ImageBox Enemyhpbar1;
        ImageBox Enemyhpbar2;
        ImageBox Enemyhpbar3;
        ImageBox Herohp1;
        ImageBox Herohp2;
        ImageBox Herohpbar1;
        ImageBox Herohpbar2;
        ImageBox Enemymp1;
        ImageBox Enemymp2;
        ImageBox Enemymp3;
        ImageBox Enemympbar1;
        ImageBox Enemympbar2;
        ImageBox Enemympbar3;
        ImageBox Heromp1;
        ImageBox Heromp2;
        ImageBox Herompbar1;
        ImageBox Herompbar2;
        ImageBox Hero1Skilltop;
        ImageBox Hero1Skillleft;
        ImageBox Hero1Skillright;
        ImageBox Hero2Skilltop;
        ImageBox Hero2Skillleft;
        ImageBox Hero2Skillright;
        Label enemy1_hpstats;
        Label enemy1_mpstats;
        Label enemy2_hpstats;
        Label enemy2_mpstats;
        Label enemy3_hpstats;
        Label enemy3_mpstats;
        Label Skillname;
        Label Skilldesc;
        Label Cooldowndesc;
        Label MPdesc;
        ImageBox HeroFrame2;
        ImageBox HeroFrame1;
        Label hero2_hpstats;
        Label hero1_mpstats;
        Label hero2_mpstats;
        Label hero1_hpstats;
        ImageBox CDHero1T;
        ImageBox CDHero1R;
        ImageBox CDHero1L;
        ImageBox CDHero2T;
        ImageBox CDHero2L;
        ImageBox CDHero2R;
        ImageBox btnHero1;
        ImageBox btnHero2;
        ImageBox btn_continue;

        private void InitializeWidget()
        {
            InitializeWidget(LayoutOrientation.Horizontal);
        }

        private void InitializeWidget(LayoutOrientation orientation)
        {
            BackgroundOverlay = new ImageBox();
            BackgroundOverlay.Name = "BackgroundOverlay";
            EnemyFrame1 = new ImageBox();
            EnemyFrame1.Name = "EnemyFrame1";
            EnemyFrame2 = new ImageBox();
            EnemyFrame2.Name = "EnemyFrame2";
            EnemyFrame3 = new ImageBox();
            EnemyFrame3.Name = "EnemyFrame3";
            btnHero1Skilltop = new ImageBox();
            btnHero1Skilltop.Name = "btnHero1Skilltop";
            btnHero1Skillleft = new ImageBox();
            btnHero1Skillleft.Name = "btnHero1Skillleft";
            btnHero1Skillright = new ImageBox();
            btnHero1Skillright.Name = "btnHero1Skillright";
            btnHero2Skilltop = new ImageBox();
            btnHero2Skilltop.Name = "btnHero2Skilltop";
            btnHero2Skillleft = new ImageBox();
            btnHero2Skillleft.Name = "btnHero2Skillleft";
            btnHero2Skillright = new ImageBox();
            btnHero2Skillright.Name = "btnHero2Skillright";
            EnemyPortrait1 = new ImageBox();
            EnemyPortrait1.Name = "EnemyPortrait1";
            EnemyPortrait2 = new ImageBox();
            EnemyPortrait2.Name = "EnemyPortrait2";
            EnemyPortrait3 = new ImageBox();
            EnemyPortrait3.Name = "EnemyPortrait3";
            HeroPortrait1 = new ImageBox();
            HeroPortrait1.Name = "HeroPortrait1";
            HeroPortrait2 = new ImageBox();
            HeroPortrait2.Name = "HeroPortrait2";
            Background = new ImageBox();
            Background.Name = "Background";
            EnemyBody1 = new ImageBox();
            EnemyBody1.Name = "EnemyBody1";
            EnemyBody2 = new ImageBox();
            EnemyBody2.Name = "EnemyBody2";
            EnemyBody3 = new ImageBox();
            EnemyBody3.Name = "EnemyBody3";
            Enemyhp1 = new ImageBox();
            Enemyhp1.Name = "Enemyhp1";
            Enemyhp2 = new ImageBox();
            Enemyhp2.Name = "Enemyhp2";
            Enemyhp3 = new ImageBox();
            Enemyhp3.Name = "Enemyhp3";
            Enemyhpbar1 = new ImageBox();
            Enemyhpbar1.Name = "Enemyhpbar1";
            Enemyhpbar2 = new ImageBox();
            Enemyhpbar2.Name = "Enemyhpbar2";
            Enemyhpbar3 = new ImageBox();
            Enemyhpbar3.Name = "Enemyhpbar3";
            Herohp1 = new ImageBox();
            Herohp1.Name = "Herohp1";
            Herohp2 = new ImageBox();
            Herohp2.Name = "Herohp2";
            Herohpbar1 = new ImageBox();
            Herohpbar1.Name = "Herohpbar1";
            Herohpbar2 = new ImageBox();
            Herohpbar2.Name = "Herohpbar2";
            Enemymp1 = new ImageBox();
            Enemymp1.Name = "Enemymp1";
            Enemymp2 = new ImageBox();
            Enemymp2.Name = "Enemymp2";
            Enemymp3 = new ImageBox();
            Enemymp3.Name = "Enemymp3";
            Enemympbar1 = new ImageBox();
            Enemympbar1.Name = "Enemympbar1";
            Enemympbar2 = new ImageBox();
            Enemympbar2.Name = "Enemympbar2";
            Enemympbar3 = new ImageBox();
            Enemympbar3.Name = "Enemympbar3";
            Heromp1 = new ImageBox();
            Heromp1.Name = "Heromp1";
            Heromp2 = new ImageBox();
            Heromp2.Name = "Heromp2";
            Herompbar1 = new ImageBox();
            Herompbar1.Name = "Herompbar1";
            Herompbar2 = new ImageBox();
            Herompbar2.Name = "Herompbar2";
            Hero1Skilltop = new ImageBox();
            Hero1Skilltop.Name = "Hero1Skilltop";
            Hero1Skillleft = new ImageBox();
            Hero1Skillleft.Name = "Hero1Skillleft";
            Hero1Skillright = new ImageBox();
            Hero1Skillright.Name = "Hero1Skillright";
            Hero2Skilltop = new ImageBox();
            Hero2Skilltop.Name = "Hero2Skilltop";
            Hero2Skillleft = new ImageBox();
            Hero2Skillleft.Name = "Hero2Skillleft";
            Hero2Skillright = new ImageBox();
            Hero2Skillright.Name = "Hero2Skillright";
            enemy1_hpstats = new Label();
            enemy1_hpstats.Name = "enemy1_hpstats";
            enemy1_mpstats = new Label();
            enemy1_mpstats.Name = "enemy1_mpstats";
            enemy2_hpstats = new Label();
            enemy2_hpstats.Name = "enemy2_hpstats";
            enemy2_mpstats = new Label();
            enemy2_mpstats.Name = "enemy2_mpstats";
            enemy3_hpstats = new Label();
            enemy3_hpstats.Name = "enemy3_hpstats";
            enemy3_mpstats = new Label();
            enemy3_mpstats.Name = "enemy3_mpstats";
            Skillname = new Label();
            Skillname.Name = "Skillname";
            Skilldesc = new Label();
            Skilldesc.Name = "Skilldesc";
            Cooldowndesc = new Label();
            Cooldowndesc.Name = "Cooldowndesc";
            MPdesc = new Label();
            MPdesc.Name = "MPdesc";
            HeroFrame2 = new ImageBox();
            HeroFrame2.Name = "HeroFrame2";
            HeroFrame1 = new ImageBox();
            HeroFrame1.Name = "HeroFrame1";
            hero2_hpstats = new Label();
            hero2_hpstats.Name = "hero2_hpstats";
            hero1_mpstats = new Label();
            hero1_mpstats.Name = "hero1_mpstats";
            hero2_mpstats = new Label();
            hero2_mpstats.Name = "hero2_mpstats";
            hero1_hpstats = new Label();
            hero1_hpstats.Name = "hero1_hpstats";
            CDHero1T = new ImageBox();
            CDHero1T.Name = "CDHero1T";
            CDHero1R = new ImageBox();
            CDHero1R.Name = "CDHero1R";
            CDHero1L = new ImageBox();
            CDHero1L.Name = "CDHero1L";
            CDHero2T = new ImageBox();
            CDHero2T.Name = "CDHero2T";
            CDHero2L = new ImageBox();
            CDHero2L.Name = "CDHero2L";
            CDHero2R = new ImageBox();
            CDHero2R.Name = "CDHero2R";
            btnHero1 = new ImageBox();
            btnHero1.Name = "btnHero1";
            btnHero2 = new ImageBox();
            btnHero2.Name = "btnHero2";
            btn_continue = new ImageBox();
            btn_continue.Name = "btn_continue";

            // BackgroundOverlay
            BackgroundOverlay.Image = new ImageAsset("assets/Combat UI/CombatBG_OverMap.png");

            // EnemyFrame1
            EnemyFrame1.Image = new ImageAsset("assets/Combat UI/CombatUI_Enemy.png");

            // EnemyFrame2
            EnemyFrame2.Image = new ImageAsset("assets/Combat UI/CombatUI_Enemy.png");

            // EnemyFrame3
            EnemyFrame3.Image = new ImageAsset("assets/Combat UI/CombatUI_Enemy.png");

            // btnHero1Skilltop
            btnHero1Skilltop.Image = new ImageAsset("assets/Combat UI/btnSkill.png");

            // btnHero1Skillleft
            btnHero1Skillleft.Image = new ImageAsset("assets/Combat UI/btnSkill.png");

            // btnHero1Skillright
            btnHero1Skillright.Image = new ImageAsset("assets/Combat UI/btnSkill.png");

            // btnHero2Skilltop
            btnHero2Skilltop.Image = new ImageAsset("assets/Combat UI/btnSkill.png");

            // btnHero2Skillleft
            btnHero2Skillleft.Image = new ImageAsset("assets/Combat UI/btnSkill.png");

            // btnHero2Skillright
            btnHero2Skillright.Image = new ImageAsset("assets/Combat UI/btnSkill.png");

            // EnemyPortrait1

            // EnemyPortrait2

            // EnemyPortrait3

            // HeroPortrait1

            // HeroPortrait2

            // Background
            Background.Image = new ImageAsset("assets/Combat UI/Combat_BorderBG.png");

            // EnemyBody1

            // EnemyBody2

            // EnemyBody3

            // Enemyhp1
            Enemyhp1.Image = new ImageAsset("assets/Combat UI/hp_empty.png");

            // Enemyhp2
            Enemyhp2.Image = new ImageAsset("assets/Combat UI/hp_empty.png");

            // Enemyhp3
            Enemyhp3.Image = new ImageAsset("assets/Combat UI/hp_empty.png");

            // Enemyhpbar1
            Enemyhpbar1.Image = new ImageAsset("assets/Combat UI/hp_full.png");

            // Enemyhpbar2
            Enemyhpbar2.Image = new ImageAsset("assets/Combat UI/hp_full.png");

            // Enemyhpbar3
            Enemyhpbar3.Image = new ImageAsset("assets/Combat UI/hp_full.png");

            // Herohp1
            Herohp1.Image = new ImageAsset("assets/Combat UI/hp_empty.png");

            // Herohp2
            Herohp2.Image = new ImageAsset("assets/Combat UI/hp_empty.png");

            // Herohpbar1
            Herohpbar1.Image = new ImageAsset("assets/Combat UI/hp_full.png");

            // Herohpbar2
            Herohpbar2.Image = new ImageAsset("assets/Combat UI/hp_full.png");

            // Enemymp1
            Enemymp1.Image = new ImageAsset("assets/Combat UI/energy_empty.png");

            // Enemymp2
            Enemymp2.Image = new ImageAsset("assets/Combat UI/energy_empty.png");

            // Enemymp3
            Enemymp3.Image = new ImageAsset("assets/Combat UI/energy_empty.png");

            // Enemympbar1
            Enemympbar1.Image = new ImageAsset("assets/Combat UI/energy_full.png");

            // Enemympbar2
            Enemympbar2.Image = new ImageAsset("assets/Combat UI/energy_full.png");

            // Enemympbar3
            Enemympbar3.Image = new ImageAsset("assets/Combat UI/energy_full.png");

            // Heromp1
            Heromp1.Image = new ImageAsset("assets/Combat UI/energy_empty.png");

            // Heromp2
            Heromp2.Image = new ImageAsset("assets/Combat UI/energy_empty.png");

            // Herompbar1
            Herompbar1.Image = new ImageAsset("assets/Combat UI/energy_full.png");

            // Herompbar2
            Herompbar2.Image = new ImageAsset("assets/Combat UI/energy_full.png");

            // Hero1Skilltop
            Hero1Skilltop.Image = new ImageAsset("assets/Combat UI/btnSkill.png");

            // Hero1Skillleft
            Hero1Skillleft.Image = new ImageAsset("assets/Combat UI/btnSkill.png");

            // Hero1Skillright
            Hero1Skillright.Image = new ImageAsset("assets/Combat UI/btnSkill.png");

            // Hero2Skilltop
            Hero2Skilltop.Image = new ImageAsset("assets/Combat UI/btnSkill.png");

            // Hero2Skillleft
            Hero2Skillleft.Image = new ImageAsset("assets/Combat UI/btnSkill.png");

            // Hero2Skillright
            Hero2Skillright.Image = new ImageAsset("assets/Combat UI/btnSkill.png");

            // enemy1_hpstats
            enemy1_hpstats.TextColor = new UIColor(254f / 255f, 252f / 255f, 252f / 255f, 255f / 255f);
            enemy1_hpstats.Font = new Font( FontAlias.System, 10, FontStyle.Bold | FontStyle.Italic);
            enemy1_hpstats.LineBreak = LineBreak.Character;

            // enemy1_mpstats
            enemy1_mpstats.TextColor = new UIColor(254f / 255f, 252f / 255f, 252f / 255f, 255f / 255f);
            enemy1_mpstats.Font = new Font( FontAlias.System, 10, FontStyle.Bold | FontStyle.Italic);
            enemy1_mpstats.LineBreak = LineBreak.Character;

            // enemy2_hpstats
            enemy2_hpstats.TextColor = new UIColor(254f / 255f, 252f / 255f, 252f / 255f, 255f / 255f);
            enemy2_hpstats.Font = new Font( FontAlias.System, 10, FontStyle.Bold | FontStyle.Italic);
            enemy2_hpstats.LineBreak = LineBreak.Character;

            // enemy2_mpstats
            enemy2_mpstats.TextColor = new UIColor(254f / 255f, 252f / 255f, 252f / 255f, 255f / 255f);
            enemy2_mpstats.Font = new Font( FontAlias.System, 10, FontStyle.Bold | FontStyle.Italic);
            enemy2_mpstats.LineBreak = LineBreak.Character;

            // enemy3_hpstats
            enemy3_hpstats.TextColor = new UIColor(254f / 255f, 252f / 255f, 252f / 255f, 255f / 255f);
            enemy3_hpstats.Font = new Font( FontAlias.System, 10, FontStyle.Bold | FontStyle.Italic);
            enemy3_hpstats.LineBreak = LineBreak.Character;

            // enemy3_mpstats
            enemy3_mpstats.TextColor = new UIColor(254f / 255f, 252f / 255f, 252f / 255f, 255f / 255f);
            enemy3_mpstats.Font = new Font( FontAlias.System, 10, FontStyle.Bold | FontStyle.Italic);
            enemy3_mpstats.LineBreak = LineBreak.Character;

            // Skillname
            Skillname.TextColor = new UIColor(252f / 255f, 246f / 255f, 246f / 255f, 255f / 255f);
            Skillname.Font = new Font( FontAlias.System, 15, FontStyle.Bold);
            Skillname.LineBreak = LineBreak.Character;

            // Skilldesc
            Skilldesc.TextColor = new UIColor(253f / 255f, 249f / 255f, 249f / 255f, 255f / 255f);
            Skilldesc.Font = new Font( FontAlias.System, 14, FontStyle.Regular);
            Skilldesc.VerticalAlignment = VerticalAlignment.Top;

            // Cooldowndesc
            Cooldowndesc.TextColor = new UIColor(253f / 255f, 249f / 255f, 249f / 255f, 255f / 255f);
            Cooldowndesc.Font = new Font( FontAlias.System, 14, FontStyle.Regular);
            Cooldowndesc.LineBreak = LineBreak.Character;
            Cooldowndesc.VerticalAlignment = VerticalAlignment.Top;

            // MPdesc
            MPdesc.TextColor = new UIColor(253f / 255f, 249f / 255f, 249f / 255f, 255f / 255f);
            MPdesc.Font = new Font( FontAlias.System, 14, FontStyle.Regular);
            MPdesc.LineBreak = LineBreak.Character;
            MPdesc.VerticalAlignment = VerticalAlignment.Top;

            // HeroFrame2
            HeroFrame2.Image = new ImageAsset("assets/Combat UI/CombatUI_Hero.png");

            // HeroFrame1
            HeroFrame1.Image = new ImageAsset("assets/Combat UI/CombatUI_Hero.png");

            // hero2_hpstats
            hero2_hpstats.TextColor = new UIColor(254f / 255f, 252f / 255f, 252f / 255f, 255f / 255f);
            hero2_hpstats.Font = new Font( FontAlias.System, 10, FontStyle.Bold | FontStyle.Italic);
            hero2_hpstats.LineBreak = LineBreak.Character;

            // hero1_mpstats
            hero1_mpstats.TextColor = new UIColor(254f / 255f, 252f / 255f, 252f / 255f, 255f / 255f);
            hero1_mpstats.Font = new Font( FontAlias.System, 10, FontStyle.Bold | FontStyle.Italic);
            hero1_mpstats.LineBreak = LineBreak.Character;

            // hero2_mpstats
            hero2_mpstats.TextColor = new UIColor(254f / 255f, 252f / 255f, 252f / 255f, 255f / 255f);
            hero2_mpstats.Font = new Font( FontAlias.System, 10, FontStyle.Bold | FontStyle.Italic);
            hero2_mpstats.LineBreak = LineBreak.Character;

            // hero1_hpstats
            hero1_hpstats.TextColor = new UIColor(254f / 255f, 252f / 255f, 252f / 255f, 255f / 255f);
            hero1_hpstats.Font = new Font( FontAlias.System, 10, FontStyle.Bold | FontStyle.Italic);
            hero1_hpstats.LineBreak = LineBreak.Character;

            // CDHero1T
            CDHero1T.Image = new ImageAsset("assets/Combat UI/red_trans2.png");

            // CDHero1R
            CDHero1R.Image = new ImageAsset("assets/Combat UI/red_trans2.png");

            // CDHero1L
            CDHero1L.Image = new ImageAsset("assets/Combat UI/red_trans2.png");

            // CDHero2T
            CDHero2T.Image = new ImageAsset("assets/Combat UI/red_trans2.png");

            // CDHero2L
            CDHero2L.Image = new ImageAsset("assets/Combat UI/red_trans2.png");

            // CDHero2R
            CDHero2R.Image = new ImageAsset("assets/Combat UI/red_trans2.png");

            // btnHero1

            // btnHero2

            // btn_continue
            btn_continue.Image = new ImageAsset("assets/GUI/Button_ContinueOn.png");

            // Scene
            this.RootWidget.AddChildLast(BackgroundOverlay);
            this.RootWidget.AddChildLast(EnemyFrame1);
            this.RootWidget.AddChildLast(EnemyFrame2);
            this.RootWidget.AddChildLast(EnemyFrame3);
            this.RootWidget.AddChildLast(btnHero1Skilltop);
            this.RootWidget.AddChildLast(btnHero1Skillleft);
            this.RootWidget.AddChildLast(btnHero1Skillright);
            this.RootWidget.AddChildLast(btnHero2Skilltop);
            this.RootWidget.AddChildLast(btnHero2Skillleft);
            this.RootWidget.AddChildLast(btnHero2Skillright);
            this.RootWidget.AddChildLast(EnemyPortrait1);
            this.RootWidget.AddChildLast(EnemyPortrait2);
            this.RootWidget.AddChildLast(EnemyPortrait3);
            this.RootWidget.AddChildLast(HeroPortrait1);
            this.RootWidget.AddChildLast(HeroPortrait2);
            this.RootWidget.AddChildLast(Background);
            this.RootWidget.AddChildLast(EnemyBody1);
            this.RootWidget.AddChildLast(EnemyBody2);
            this.RootWidget.AddChildLast(EnemyBody3);
            this.RootWidget.AddChildLast(Enemyhp1);
            this.RootWidget.AddChildLast(Enemyhp2);
            this.RootWidget.AddChildLast(Enemyhp3);
            this.RootWidget.AddChildLast(Enemyhpbar1);
            this.RootWidget.AddChildLast(Enemyhpbar2);
            this.RootWidget.AddChildLast(Enemyhpbar3);
            this.RootWidget.AddChildLast(Herohp1);
            this.RootWidget.AddChildLast(Herohp2);
            this.RootWidget.AddChildLast(Herohpbar1);
            this.RootWidget.AddChildLast(Herohpbar2);
            this.RootWidget.AddChildLast(Enemymp1);
            this.RootWidget.AddChildLast(Enemymp2);
            this.RootWidget.AddChildLast(Enemymp3);
            this.RootWidget.AddChildLast(Enemympbar1);
            this.RootWidget.AddChildLast(Enemympbar2);
            this.RootWidget.AddChildLast(Enemympbar3);
            this.RootWidget.AddChildLast(Heromp1);
            this.RootWidget.AddChildLast(Heromp2);
            this.RootWidget.AddChildLast(Herompbar1);
            this.RootWidget.AddChildLast(Herompbar2);
            this.RootWidget.AddChildLast(Hero1Skilltop);
            this.RootWidget.AddChildLast(Hero1Skillleft);
            this.RootWidget.AddChildLast(Hero1Skillright);
            this.RootWidget.AddChildLast(Hero2Skilltop);
            this.RootWidget.AddChildLast(Hero2Skillleft);
            this.RootWidget.AddChildLast(Hero2Skillright);
            this.RootWidget.AddChildLast(enemy1_hpstats);
            this.RootWidget.AddChildLast(enemy1_mpstats);
            this.RootWidget.AddChildLast(enemy2_hpstats);
            this.RootWidget.AddChildLast(enemy2_mpstats);
            this.RootWidget.AddChildLast(enemy3_hpstats);
            this.RootWidget.AddChildLast(enemy3_mpstats);
            this.RootWidget.AddChildLast(Skillname);
            this.RootWidget.AddChildLast(Skilldesc);
            this.RootWidget.AddChildLast(Cooldowndesc);
            this.RootWidget.AddChildLast(MPdesc);
            this.RootWidget.AddChildLast(HeroFrame2);
            this.RootWidget.AddChildLast(HeroFrame1);
            this.RootWidget.AddChildLast(hero2_hpstats);
            this.RootWidget.AddChildLast(hero1_mpstats);
            this.RootWidget.AddChildLast(hero2_mpstats);
            this.RootWidget.AddChildLast(hero1_hpstats);
            this.RootWidget.AddChildLast(CDHero1T);
            this.RootWidget.AddChildLast(CDHero1R);
            this.RootWidget.AddChildLast(CDHero1L);
            this.RootWidget.AddChildLast(CDHero2T);
            this.RootWidget.AddChildLast(CDHero2L);
            this.RootWidget.AddChildLast(CDHero2R);
            this.RootWidget.AddChildLast(btnHero1);
            this.RootWidget.AddChildLast(btnHero2);
            this.RootWidget.AddChildLast(btn_continue);
            this.Showing += new EventHandler(onShowing);
            this.Shown += new EventHandler(onShown);

            SetWidgetLayout(orientation);

            UpdateLanguage();
        }

        private LayoutOrientation _currentLayoutOrientation;
        public void SetWidgetLayout(LayoutOrientation orientation)
        {
            switch (orientation)
            {
            case LayoutOrientation.Vertical:
                this.DesignWidth = 480;
                this.DesignHeight = 854;

                BackgroundOverlay.SetPosition(183, 109);
                BackgroundOverlay.SetSize(200, 200);
                BackgroundOverlay.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                BackgroundOverlay.Visible = true;

                EnemyFrame1.SetPosition(314, 8);
                EnemyFrame1.SetSize(200, 200);
                EnemyFrame1.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                EnemyFrame1.Visible = true;

                EnemyFrame2.SetPosition(314, 8);
                EnemyFrame2.SetSize(200, 200);
                EnemyFrame2.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                EnemyFrame2.Visible = true;

                EnemyFrame3.SetPosition(314, 8);
                EnemyFrame3.SetSize(200, 200);
                EnemyFrame3.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                EnemyFrame3.Visible = true;

                btnHero1Skilltop.SetPosition(463, 153);
                btnHero1Skilltop.SetSize(200, 200);
                btnHero1Skilltop.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                btnHero1Skilltop.Visible = true;

                btnHero1Skillleft.SetPosition(463, 153);
                btnHero1Skillleft.SetSize(200, 200);
                btnHero1Skillleft.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                btnHero1Skillleft.Visible = true;

                btnHero1Skillright.SetPosition(463, 153);
                btnHero1Skillright.SetSize(200, 200);
                btnHero1Skillright.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                btnHero1Skillright.Visible = true;

                btnHero2Skilltop.SetPosition(463, 153);
                btnHero2Skilltop.SetSize(200, 200);
                btnHero2Skilltop.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                btnHero2Skilltop.Visible = true;

                btnHero2Skillleft.SetPosition(463, 153);
                btnHero2Skillleft.SetSize(200, 200);
                btnHero2Skillleft.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                btnHero2Skillleft.Visible = true;

                btnHero2Skillright.SetPosition(463, 153);
                btnHero2Skillright.SetSize(200, 200);
                btnHero2Skillright.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                btnHero2Skillright.Visible = true;

                EnemyPortrait1.SetPosition(153, 100);
                EnemyPortrait1.SetSize(200, 200);
                EnemyPortrait1.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                EnemyPortrait1.Visible = true;

                EnemyPortrait2.SetPosition(153, 100);
                EnemyPortrait2.SetSize(200, 200);
                EnemyPortrait2.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                EnemyPortrait2.Visible = true;

                EnemyPortrait3.SetPosition(153, 100);
                EnemyPortrait3.SetSize(200, 200);
                EnemyPortrait3.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                EnemyPortrait3.Visible = true;

                HeroPortrait1.SetPosition(153, 100);
                HeroPortrait1.SetSize(200, 200);
                HeroPortrait1.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                HeroPortrait1.Visible = true;

                HeroPortrait2.SetPosition(153, 100);
                HeroPortrait2.SetSize(200, 200);
                HeroPortrait2.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                HeroPortrait2.Visible = true;

                Background.SetPosition(337, 77);
                Background.SetSize(200, 200);
                Background.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                Background.Visible = true;

                EnemyBody1.SetPosition(81, 121);
                EnemyBody1.SetSize(200, 200);
                EnemyBody1.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                EnemyBody1.Visible = true;

                EnemyBody2.SetPosition(81, 121);
                EnemyBody2.SetSize(200, 200);
                EnemyBody2.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                EnemyBody2.Visible = true;

                EnemyBody3.SetPosition(81, 121);
                EnemyBody3.SetSize(200, 200);
                EnemyBody3.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                EnemyBody3.Visible = true;

                Enemyhp1.SetPosition(774, 269);
                Enemyhp1.SetSize(200, 200);
                Enemyhp1.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                Enemyhp1.Visible = true;

                Enemyhp2.SetPosition(774, 269);
                Enemyhp2.SetSize(200, 200);
                Enemyhp2.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                Enemyhp2.Visible = true;

                Enemyhp3.SetPosition(774, 269);
                Enemyhp3.SetSize(200, 200);
                Enemyhp3.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                Enemyhp3.Visible = true;

                Enemyhpbar1.SetPosition(265, 314);
                Enemyhpbar1.SetSize(200, 200);
                Enemyhpbar1.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                Enemyhpbar1.Visible = true;

                Enemyhpbar2.SetPosition(265, 314);
                Enemyhpbar2.SetSize(200, 200);
                Enemyhpbar2.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                Enemyhpbar2.Visible = true;

                Enemyhpbar3.SetPosition(265, 314);
                Enemyhpbar3.SetSize(200, 200);
                Enemyhpbar3.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                Enemyhpbar3.Visible = true;

                Herohp1.SetPosition(774, 269);
                Herohp1.SetSize(200, 200);
                Herohp1.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                Herohp1.Visible = true;

                Herohp2.SetPosition(774, 269);
                Herohp2.SetSize(200, 200);
                Herohp2.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                Herohp2.Visible = true;

                Herohpbar1.SetPosition(265, 314);
                Herohpbar1.SetSize(200, 200);
                Herohpbar1.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                Herohpbar1.Visible = true;

                Herohpbar2.SetPosition(265, 314);
                Herohpbar2.SetSize(200, 200);
                Herohpbar2.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                Herohpbar2.Visible = true;

                Enemymp1.SetPosition(494, 237);
                Enemymp1.SetSize(200, 200);
                Enemymp1.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                Enemymp1.Visible = true;

                Enemymp2.SetPosition(494, 237);
                Enemymp2.SetSize(200, 200);
                Enemymp2.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                Enemymp2.Visible = true;

                Enemymp3.SetPosition(494, 237);
                Enemymp3.SetSize(200, 200);
                Enemymp3.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                Enemymp3.Visible = true;

                Enemympbar1.SetPosition(461, 238);
                Enemympbar1.SetSize(200, 200);
                Enemympbar1.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                Enemympbar1.Visible = true;

                Enemympbar2.SetPosition(461, 238);
                Enemympbar2.SetSize(200, 200);
                Enemympbar2.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                Enemympbar2.Visible = true;

                Enemympbar3.SetPosition(461, 238);
                Enemympbar3.SetSize(200, 200);
                Enemympbar3.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                Enemympbar3.Visible = true;

                Heromp1.SetPosition(494, 237);
                Heromp1.SetSize(200, 200);
                Heromp1.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                Heromp1.Visible = true;

                Heromp2.SetPosition(494, 237);
                Heromp2.SetSize(200, 200);
                Heromp2.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                Heromp2.Visible = true;

                Herompbar1.SetPosition(383, 339);
                Herompbar1.SetSize(200, 200);
                Herompbar1.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                Herompbar1.Visible = true;

                Herompbar2.SetPosition(383, 339);
                Herompbar2.SetSize(200, 200);
                Herompbar2.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                Herompbar2.Visible = true;

                Hero1Skilltop.SetPosition(463, 153);
                Hero1Skilltop.SetSize(200, 200);
                Hero1Skilltop.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                Hero1Skilltop.Visible = true;

                Hero1Skillleft.SetPosition(463, 153);
                Hero1Skillleft.SetSize(200, 200);
                Hero1Skillleft.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                Hero1Skillleft.Visible = true;

                Hero1Skillright.SetPosition(463, 153);
                Hero1Skillright.SetSize(200, 200);
                Hero1Skillright.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                Hero1Skillright.Visible = true;

                Hero2Skilltop.SetPosition(463, 153);
                Hero2Skilltop.SetSize(200, 200);
                Hero2Skilltop.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                Hero2Skilltop.Visible = true;

                Hero2Skillleft.SetPosition(463, 153);
                Hero2Skillleft.SetSize(200, 200);
                Hero2Skillleft.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                Hero2Skillleft.Visible = true;

                Hero2Skillright.SetPosition(463, 153);
                Hero2Skillright.SetSize(200, 200);
                Hero2Skillright.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                Hero2Skillright.Visible = true;

                enemy1_hpstats.SetPosition(255, 87);
                enemy1_hpstats.SetSize(214, 36);
                enemy1_hpstats.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                enemy1_hpstats.Visible = true;

                enemy1_mpstats.SetPosition(255, 87);
                enemy1_mpstats.SetSize(214, 36);
                enemy1_mpstats.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                enemy1_mpstats.Visible = true;

                enemy2_hpstats.SetPosition(255, 87);
                enemy2_hpstats.SetSize(214, 36);
                enemy2_hpstats.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                enemy2_hpstats.Visible = true;

                enemy2_mpstats.SetPosition(255, 87);
                enemy2_mpstats.SetSize(214, 36);
                enemy2_mpstats.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                enemy2_mpstats.Visible = true;

                enemy3_hpstats.SetPosition(255, 87);
                enemy3_hpstats.SetSize(214, 36);
                enemy3_hpstats.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                enemy3_hpstats.Visible = true;

                enemy3_mpstats.SetPosition(255, 87);
                enemy3_mpstats.SetSize(214, 36);
                enemy3_mpstats.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                enemy3_mpstats.Visible = true;

                Skillname.SetPosition(-56, 366);
                Skillname.SetSize(214, 36);
                Skillname.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                Skillname.Visible = true;

                Skilldesc.SetPosition(1, 395);
                Skilldesc.SetSize(214, 36);
                Skilldesc.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                Skilldesc.Visible = true;

                Cooldowndesc.SetPosition(1, 395);
                Cooldowndesc.SetSize(214, 36);
                Cooldowndesc.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                Cooldowndesc.Visible = true;

                MPdesc.SetPosition(1, 395);
                MPdesc.SetSize(214, 36);
                MPdesc.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                MPdesc.Visible = true;

                HeroFrame2.SetPosition(156, 164);
                HeroFrame2.SetSize(200, 200);
                HeroFrame2.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                HeroFrame2.Visible = true;

                HeroFrame1.SetPosition(156, 164);
                HeroFrame1.SetSize(200, 200);
                HeroFrame1.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                HeroFrame1.Visible = true;

                hero2_hpstats.SetPosition(255, 87);
                hero2_hpstats.SetSize(214, 36);
                hero2_hpstats.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                hero2_hpstats.Visible = true;

                hero1_mpstats.SetPosition(255, 87);
                hero1_mpstats.SetSize(214, 36);
                hero1_mpstats.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                hero1_mpstats.Visible = true;

                hero2_mpstats.SetPosition(255, 87);
                hero2_mpstats.SetSize(214, 36);
                hero2_mpstats.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                hero2_mpstats.Visible = true;

                hero1_hpstats.SetPosition(255, 87);
                hero1_hpstats.SetSize(214, 36);
                hero1_hpstats.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                hero1_hpstats.Visible = true;

                CDHero1T.SetPosition(397, 336);
                CDHero1T.SetSize(200, 200);
                CDHero1T.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                CDHero1T.Visible = true;

                CDHero1R.SetPosition(397, 336);
                CDHero1R.SetSize(200, 200);
                CDHero1R.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                CDHero1R.Visible = true;

                CDHero1L.SetPosition(397, 336);
                CDHero1L.SetSize(200, 200);
                CDHero1L.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                CDHero1L.Visible = true;

                CDHero2T.SetPosition(397, 336);
                CDHero2T.SetSize(200, 200);
                CDHero2T.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                CDHero2T.Visible = true;

                CDHero2L.SetPosition(397, 336);
                CDHero2L.SetSize(200, 200);
                CDHero2L.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                CDHero2L.Visible = true;

                CDHero2R.SetPosition(397, 336);
                CDHero2R.SetSize(200, 200);
                CDHero2R.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                CDHero2R.Visible = true;

                btnHero1.SetPosition(307, 183);
                btnHero1.SetSize(200, 200);
                btnHero1.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                btnHero1.Visible = true;

                btnHero2.SetPosition(307, 183);
                btnHero2.SetSize(200, 200);
                btnHero2.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                btnHero2.Visible = true;

                btn_continue.SetPosition(355, 308);
                btn_continue.SetSize(200, 200);
                btn_continue.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                btn_continue.Visible = true;

                break;

            default:
                this.DesignWidth = 854;
                this.DesignHeight = 480;

                BackgroundOverlay.SetPosition(0, 0);
                BackgroundOverlay.SetSize(854, 480);
                BackgroundOverlay.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                BackgroundOverlay.Visible = true;

                EnemyFrame1.SetPosition(103, 15);
                EnemyFrame1.SetSize(126, 80);
                EnemyFrame1.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                EnemyFrame1.Visible = true;

                EnemyFrame2.SetPosition(353, 15);
                EnemyFrame2.SetSize(126, 80);
                EnemyFrame2.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                EnemyFrame2.Visible = true;

                EnemyFrame3.SetPosition(603, 15);
                EnemyFrame3.SetSize(126, 80);
                EnemyFrame3.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                EnemyFrame3.Visible = true;

                btnHero1Skilltop.SetPosition(406, 372);
                btnHero1Skilltop.SetSize(33, 39);
                btnHero1Skilltop.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                btnHero1Skilltop.Visible = true;

                btnHero1Skillleft.SetPosition(389, 402);
                btnHero1Skillleft.SetSize(33, 39);
                btnHero1Skillleft.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                btnHero1Skillleft.Visible = true;

                btnHero1Skillright.SetPosition(424, 402);
                btnHero1Skillright.SetSize(33, 39);
                btnHero1Skillright.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                btnHero1Skillright.Visible = true;

                btnHero2Skilltop.SetPosition(631, 372);
                btnHero2Skilltop.SetSize(33, 39);
                btnHero2Skilltop.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                btnHero2Skilltop.Visible = true;

                btnHero2Skillleft.SetPosition(613, 402);
                btnHero2Skillleft.SetSize(33, 39);
                btnHero2Skillleft.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                btnHero2Skillleft.Visible = true;

                btnHero2Skillright.SetPosition(648, 402);
                btnHero2Skillright.SetSize(33, 39);
                btnHero2Skillright.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                btnHero2Skillright.Visible = true;

                EnemyPortrait1.SetPosition(108, 22);
                EnemyPortrait1.SetSize(50, 65);
                EnemyPortrait1.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                EnemyPortrait1.Visible = true;

                EnemyPortrait2.SetPosition(359, 23);
                EnemyPortrait2.SetSize(50, 65);
                EnemyPortrait2.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                EnemyPortrait2.Visible = true;

                EnemyPortrait3.SetPosition(608, 23);
                EnemyPortrait3.SetSize(50, 65);
                EnemyPortrait3.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                EnemyPortrait3.Visible = true;

                HeroPortrait1.SetPosition(262, 382);
                HeroPortrait1.SetSize(60, 78);
                HeroPortrait1.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                HeroPortrait1.Visible = true;

                HeroPortrait2.SetPosition(487, 383);
                HeroPortrait2.SetSize(60, 78);
                HeroPortrait2.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                HeroPortrait2.Visible = true;

                Background.SetPosition(0, 0);
                Background.SetSize(854, 480);
                Background.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                Background.Visible = true;

                EnemyBody1.SetPosition(53, 88);
                EnemyBody1.SetSize(212, 275);
                EnemyBody1.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                EnemyBody1.Visible = true;

                EnemyBody2.SetPosition(307, 88);
                EnemyBody2.SetSize(212, 275);
                EnemyBody2.Anchors = Anchors.Top | Anchors.Bottom | Anchors.Left | Anchors.Right;
                EnemyBody2.Visible = true;

                EnemyBody3.SetPosition(562, 88);
                EnemyBody3.SetSize(212, 275);
                EnemyBody3.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                EnemyBody3.Visible = true;

                Enemyhp1.SetPosition(161, 38);
                Enemyhp1.SetSize(50, 22);
                Enemyhp1.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                Enemyhp1.Visible = true;

                Enemyhp2.SetPosition(411, 39);
                Enemyhp2.SetSize(50, 21);
                Enemyhp2.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                Enemyhp2.Visible = true;

                Enemyhp3.SetPosition(661, 38);
                Enemyhp3.SetSize(50, 22);
                Enemyhp3.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                Enemyhp3.Visible = true;

                Enemyhpbar1.SetPosition(161, 38);
                Enemyhpbar1.SetSize(50, 22);
                Enemyhpbar1.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                Enemyhpbar1.Visible = true;

                Enemyhpbar2.SetPosition(411, 39);
                Enemyhpbar2.SetSize(50, 21);
                Enemyhpbar2.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                Enemyhpbar2.Visible = true;

                Enemyhpbar3.SetPosition(661, 38);
                Enemyhpbar3.SetSize(50, 22);
                Enemyhpbar3.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                Enemyhpbar3.Visible = true;

                Herohp1.SetPosition(328, 403);
                Herohp1.SetSize(59, 24);
                Herohp1.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                Herohp1.Visible = true;

                Herohp2.SetPosition(552, 404);
                Herohp2.SetSize(59, 24);
                Herohp2.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                Herohp2.Visible = true;

                Herohpbar1.SetPosition(328, 403);
                Herohpbar1.SetSize(59, 24);
                Herohpbar1.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                Herohpbar1.Visible = true;

                Herohpbar2.SetPosition(552, 404);
                Herohpbar2.SetSize(59, 24);
                Herohpbar2.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                Herohpbar2.Visible = true;

                Enemymp1.SetPosition(161, 60);
                Enemymp1.SetSize(54, 18);
                Enemymp1.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                Enemymp1.Visible = true;

                Enemymp2.SetPosition(411, 60);
                Enemymp2.SetSize(54, 18);
                Enemymp2.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                Enemymp2.Visible = true;

                Enemymp3.SetPosition(661, 60);
                Enemymp3.SetSize(54, 18);
                Enemymp3.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                Enemymp3.Visible = true;

                Enemympbar1.SetPosition(161, 60);
                Enemympbar1.SetSize(54, 18);
                Enemympbar1.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                Enemympbar1.Visible = true;

                Enemympbar2.SetPosition(411, 60);
                Enemympbar2.SetSize(54, 18);
                Enemympbar2.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                Enemympbar2.Visible = true;

                Enemympbar3.SetPosition(661, 60);
                Enemympbar3.SetSize(54, 18);
                Enemympbar3.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                Enemympbar3.Visible = true;

                Heromp1.SetPosition(328, 431);
                Heromp1.SetSize(65, 22);
                Heromp1.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                Heromp1.Visible = true;

                Heromp2.SetPosition(552, 431);
                Heromp2.SetSize(65, 22);
                Heromp2.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                Heromp2.Visible = true;

                Herompbar1.SetPosition(328, 431);
                Herompbar1.SetSize(65, 22);
                Herompbar1.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                Herompbar1.Visible = true;

                Herompbar2.SetPosition(552, 431);
                Herompbar2.SetSize(65, 22);
                Herompbar2.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                Herompbar2.Visible = true;

                Hero1Skilltop.SetPosition(406, 372);
                Hero1Skilltop.SetSize(33, 39);
                Hero1Skilltop.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                Hero1Skilltop.Visible = true;

                Hero1Skillleft.SetPosition(389, 402);
                Hero1Skillleft.SetSize(33, 39);
                Hero1Skillleft.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                Hero1Skillleft.Visible = true;

                Hero1Skillright.SetPosition(424, 402);
                Hero1Skillright.SetSize(33, 39);
                Hero1Skillright.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                Hero1Skillright.Visible = true;

                Hero2Skilltop.SetPosition(631, 372);
                Hero2Skilltop.SetSize(33, 39);
                Hero2Skilltop.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                Hero2Skilltop.Visible = true;

                Hero2Skillleft.SetPosition(613, 402);
                Hero2Skillleft.SetSize(33, 39);
                Hero2Skillleft.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                Hero2Skillleft.Visible = true;

                Hero2Skillright.SetPosition(648, 402);
                Hero2Skillright.SetSize(33, 39);
                Hero2Skillright.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                Hero2Skillright.Visible = true;

                enemy1_hpstats.SetPosition(164, 38);
                enemy1_hpstats.SetSize(103, 36);
                enemy1_hpstats.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                enemy1_hpstats.Visible = true;

                enemy1_mpstats.SetPosition(164, 56);
                enemy1_mpstats.SetSize(103, 36);
                enemy1_mpstats.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                enemy1_mpstats.Visible = true;

                enemy2_hpstats.SetPosition(414, 38);
                enemy2_hpstats.SetSize(103, 36);
                enemy2_hpstats.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                enemy2_hpstats.Visible = true;

                enemy2_mpstats.SetPosition(414, 56);
                enemy2_mpstats.SetSize(103, 36);
                enemy2_mpstats.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                enemy2_mpstats.Visible = true;

                enemy3_hpstats.SetPosition(664, 37);
                enemy3_hpstats.SetSize(103, 36);
                enemy3_hpstats.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                enemy3_hpstats.Visible = true;

                enemy3_mpstats.SetPosition(664, 56);
                enemy3_mpstats.SetSize(103, 36);
                enemy3_mpstats.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                enemy3_mpstats.Visible = true;

                Skillname.SetPosition(23, 367);
                Skillname.SetSize(214, 36);
                Skillname.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                Skillname.Visible = false;

                Skilldesc.SetPosition(23, 442);
                Skilldesc.SetSize(232, 30);
                Skilldesc.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                Skilldesc.Visible = false;

                Cooldowndesc.SetPosition(23, 402);
                Cooldowndesc.SetSize(284, 21);
                Cooldowndesc.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                Cooldowndesc.Visible = false;

                MPdesc.SetPosition(23, 423);
                MPdesc.SetSize(284, 19);
                MPdesc.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                MPdesc.Visible = false;

                HeroFrame2.SetPosition(479, 365);
                HeroFrame2.SetSize(209, 113);
                HeroFrame2.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                HeroFrame2.Visible = true;

                HeroFrame1.SetPosition(255, 365);
                HeroFrame1.SetSize(209, 113);
                HeroFrame1.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                HeroFrame1.Visible = true;

                hero2_hpstats.SetPosition(559, 405);
                hero2_hpstats.SetSize(54, 36);
                hero2_hpstats.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                hero2_hpstats.Visible = true;

                hero1_mpstats.SetPosition(336, 430);
                hero1_mpstats.SetSize(53, 36);
                hero1_mpstats.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                hero1_mpstats.Visible = true;

                hero2_mpstats.SetPosition(560, 430);
                hero2_mpstats.SetSize(53, 36);
                hero2_mpstats.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                hero2_mpstats.Visible = true;

                hero1_hpstats.SetPosition(336, 403);
                hero1_hpstats.SetSize(53, 36);
                hero1_hpstats.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                hero1_hpstats.Visible = true;

                CDHero1T.SetPosition(406, 374);
                CDHero1T.SetSize(34, 34);
                CDHero1T.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                CDHero1T.Visible = false;

                CDHero1R.SetPosition(423, 405);
                CDHero1R.SetSize(34, 34);
                CDHero1R.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                CDHero1R.Visible = false;

                CDHero1L.SetPosition(388, 404);
                CDHero1L.SetSize(34, 34);
                CDHero1L.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                CDHero1L.Visible = false;

                CDHero2T.SetPosition(630, 374);
                CDHero2T.SetSize(34, 34);
                CDHero2T.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                CDHero2T.Visible = false;

                CDHero2L.SetPosition(612, 404);
                CDHero2L.SetSize(34, 34);
                CDHero2L.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                CDHero2L.Visible = false;

                CDHero2R.SetPosition(648, 404);
                CDHero2R.SetSize(34, 34);
                CDHero2R.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                CDHero2R.Visible = false;

                btnHero1.SetPosition(258, 380);
                btnHero1.SetSize(67, 83);
                btnHero1.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                btnHero1.Visible = true;

                btnHero2.SetPosition(484, 381);
                btnHero2.SetSize(67, 83);
                btnHero2.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                btnHero2.Visible = true;

                btn_continue.SetPosition(345, 191);
                btn_continue.SetSize(154, 51);
                btn_continue.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                btn_continue.Visible = false;

                break;
            }
            _currentLayoutOrientation = orientation;
        }
        public void UpdateLanguage()
        {
            enemy1_hpstats.Text = "100/100";
            enemy1_mpstats.Text = "100/100";
            enemy2_hpstats.Text = "100/100";
            enemy2_mpstats.Text = "100/100";
            enemy3_hpstats.Text = "100/100";
            enemy3_mpstats.Text = "100/100";
            Skillname.Text = "Quick Strike";
            Skilldesc.Text = "Damage: 25 to a single enemy";
            Cooldowndesc.Text = "Cooldown: 30s";
            MPdesc.Text = "MP: 25";
            hero2_hpstats.Text = "100/100";
            hero1_mpstats.Text = "100/100";
            hero2_mpstats.Text = "100/100";
            hero1_hpstats.Text = "100/100";
        }
        private void onShowing(object sender, EventArgs e)
        {
            switch (_currentLayoutOrientation)
            {
                case LayoutOrientation.Vertical:
                {
                    EnemyFrame1.Visible = false;
                    EnemyFrame2.Visible = false;
                    EnemyFrame3.Visible = false;
                    btnHero1Skilltop.Visible = false;
                    btnHero1Skillleft.Visible = false;
                    btnHero1Skillright.Visible = false;
                    btnHero2Skilltop.Visible = false;
                    btnHero2Skillleft.Visible = false;
                    btnHero2Skillright.Visible = false;
                    EnemyPortrait1.Visible = false;
                    EnemyPortrait2.Visible = false;
                    EnemyPortrait3.Visible = false;
                    HeroPortrait1.Visible = false;
                    HeroPortrait2.Visible = false;
                    Background.Visible = false;
                    EnemyBody1.Visible = false;
                    EnemyBody2.Visible = false;
                    EnemyBody3.Visible = false;
                    Enemyhp1.Visible = false;
                    Enemyhp2.Visible = false;
                    Enemyhp3.Visible = false;
                    Enemyhpbar1.Visible = false;
                    Enemyhpbar2.Visible = false;
                    Enemyhpbar3.Visible = false;
                    Herohp1.Visible = false;
                    Herohp2.Visible = false;
                    Herohpbar1.Visible = false;
                    Herohpbar2.Visible = false;
                    Enemymp1.Visible = false;
                    Enemymp2.Visible = false;
                    Enemymp3.Visible = false;
                    Enemympbar1.Visible = false;
                    Enemympbar2.Visible = false;
                    Enemympbar3.Visible = false;
                    Heromp1.Visible = false;
                    Heromp2.Visible = false;
                    Herompbar1.Visible = false;
                    Herompbar2.Visible = false;
                    Hero1Skilltop.Visible = false;
                    Hero1Skillleft.Visible = false;
                    Hero1Skillright.Visible = false;
                    Hero2Skilltop.Visible = false;
                    Hero2Skillleft.Visible = false;
                    Hero2Skillright.Visible = false;
                    enemy1_hpstats.Visible = false;
                    enemy1_mpstats.Visible = false;
                    enemy2_hpstats.Visible = false;
                    enemy2_mpstats.Visible = false;
                    enemy3_hpstats.Visible = false;
                    enemy3_mpstats.Visible = false;
                    HeroFrame2.Visible = false;
                    HeroFrame1.Visible = false;
                    hero2_hpstats.Visible = false;
                    hero1_mpstats.Visible = false;
                    hero2_mpstats.Visible = false;
                    hero1_hpstats.Visible = false;
                }
                break;

                default:
                {
                    EnemyFrame1.Visible = false;
                    EnemyFrame2.Visible = false;
                    EnemyFrame3.Visible = false;
                    btnHero1Skilltop.Visible = false;
                    btnHero1Skillleft.Visible = false;
                    btnHero1Skillright.Visible = false;
                    btnHero2Skilltop.Visible = false;
                    btnHero2Skillleft.Visible = false;
                    btnHero2Skillright.Visible = false;
                    EnemyPortrait1.Visible = false;
                    EnemyPortrait2.Visible = false;
                    EnemyPortrait3.Visible = false;
                    HeroPortrait1.Visible = false;
                    HeroPortrait2.Visible = false;
                    Background.Visible = false;
                    EnemyBody1.Visible = false;
                    EnemyBody2.Visible = false;
                    EnemyBody3.Visible = false;
                    Enemyhp1.Visible = false;
                    Enemyhp2.Visible = false;
                    Enemyhp3.Visible = false;
                    Enemyhpbar1.Visible = false;
                    Enemyhpbar2.Visible = false;
                    Enemyhpbar3.Visible = false;
                    Herohp1.Visible = false;
                    Herohp2.Visible = false;
                    Herohpbar1.Visible = false;
                    Herohpbar2.Visible = false;
                    Enemymp1.Visible = false;
                    Enemymp2.Visible = false;
                    Enemymp3.Visible = false;
                    Enemympbar1.Visible = false;
                    Enemympbar2.Visible = false;
                    Enemympbar3.Visible = false;
                    Heromp1.Visible = false;
                    Heromp2.Visible = false;
                    Herompbar1.Visible = false;
                    Herompbar2.Visible = false;
                    Hero1Skilltop.Visible = false;
                    Hero1Skillleft.Visible = false;
                    Hero1Skillright.Visible = false;
                    Hero2Skilltop.Visible = false;
                    Hero2Skillleft.Visible = false;
                    Hero2Skillright.Visible = false;
                    enemy1_hpstats.Visible = false;
                    enemy1_mpstats.Visible = false;
                    enemy2_hpstats.Visible = false;
                    enemy2_mpstats.Visible = false;
                    enemy3_hpstats.Visible = false;
                    enemy3_mpstats.Visible = false;
                    HeroFrame2.Visible = false;
                    HeroFrame1.Visible = false;
                    hero2_hpstats.Visible = false;
                    hero1_mpstats.Visible = false;
                    hero2_mpstats.Visible = false;
                    hero1_hpstats.Visible = false;
                }
                break;
            }
        }
        private void onShown(object sender, EventArgs e)
        {
            switch (_currentLayoutOrientation)
            {
                case LayoutOrientation.Vertical:
                {
                    new SlideInEffect()
                    {
                        Widget = EnemyFrame1,
                        MoveDirection = FourWayDirection.Down,
                    }
                    .Start();
                    new SlideInEffect()
                    {
                        Widget = EnemyFrame2,
                        MoveDirection = FourWayDirection.Down,
                    }
                    .Start();
                    new SlideInEffect()
                    {
                        Widget = EnemyFrame3,
                        MoveDirection = FourWayDirection.Down,
                    }
                    .Start();
                    new SlideInEffect()
                    {
                        Widget = btnHero1Skilltop,
                        MoveDirection = FourWayDirection.Up,
                    }
                    .Start();
                    new SlideInEffect()
                    {
                        Widget = btnHero1Skillleft,
                        MoveDirection = FourWayDirection.Up,
                    }
                    .Start();
                    new SlideInEffect()
                    {
                        Widget = btnHero1Skillright,
                        MoveDirection = FourWayDirection.Up,
                    }
                    .Start();
                    new SlideInEffect()
                    {
                        Widget = btnHero2Skilltop,
                        MoveDirection = FourWayDirection.Up,
                    }
                    .Start();
                    new SlideInEffect()
                    {
                        Widget = btnHero2Skillleft,
                        MoveDirection = FourWayDirection.Up,
                    }
                    .Start();
                    new SlideInEffect()
                    {
                        Widget = btnHero2Skillright,
                        MoveDirection = FourWayDirection.Up,
                    }
                    .Start();
                    new SlideInEffect()
                    {
                        Widget = EnemyPortrait1,
                        MoveDirection = FourWayDirection.Down,
                    }
                    .Start();
                    new SlideInEffect()
                    {
                        Widget = EnemyPortrait2,
                        MoveDirection = FourWayDirection.Down,
                    }
                    .Start();
                    new SlideInEffect()
                    {
                        Widget = EnemyPortrait3,
                        MoveDirection = FourWayDirection.Down,
                    }
                    .Start();
                    new SlideInEffect()
                    {
                        Widget = HeroPortrait1,
                        MoveDirection = FourWayDirection.Up,
                    }
                    .Start();
                    new SlideInEffect()
                    {
                        Widget = HeroPortrait2,
                        MoveDirection = FourWayDirection.Up,
                    }
                    .Start();
                    new FadeInEffect()
                    {
                        Widget = Background,
                    }
                    .Start();
                    new FadeInEffect()
                    {
                        Widget = EnemyBody1,
                    }
                    .Start();
                    new FadeInEffect()
                    {
                        Widget = EnemyBody2,
                    }
                    .Start();
                    new FadeInEffect()
                    {
                        Widget = EnemyBody3,
                    }
                    .Start();
                    new SlideInEffect()
                    {
                        Widget = Enemyhp1,
                        MoveDirection = FourWayDirection.Down,
                    }
                    .Start();
                    new SlideInEffect()
                    {
                        Widget = Enemyhp2,
                        MoveDirection = FourWayDirection.Down,
                    }
                    .Start();
                    new SlideInEffect()
                    {
                        Widget = Enemyhp3,
                        MoveDirection = FourWayDirection.Down,
                    }
                    .Start();
                    new SlideInEffect()
                    {
                        Widget = Enemyhpbar1,
                        MoveDirection = FourWayDirection.Down,
                    }
                    .Start();
                    new SlideInEffect()
                    {
                        Widget = Enemyhpbar2,
                        MoveDirection = FourWayDirection.Down,
                    }
                    .Start();
                    new SlideInEffect()
                    {
                        Widget = Enemyhpbar3,
                        MoveDirection = FourWayDirection.Down,
                    }
                    .Start();
                    new SlideInEffect()
                    {
                        Widget = Herohp1,
                        MoveDirection = FourWayDirection.Up,
                    }
                    .Start();
                    new SlideInEffect()
                    {
                        Widget = Herohp2,
                        MoveDirection = FourWayDirection.Up,
                    }
                    .Start();
                    new SlideInEffect()
                    {
                        Widget = Herohpbar1,
                        MoveDirection = FourWayDirection.Up,
                    }
                    .Start();
                    new SlideInEffect()
                    {
                        Widget = Herohpbar2,
                        MoveDirection = FourWayDirection.Up,
                    }
                    .Start();
                    new SlideInEffect()
                    {
                        Widget = Enemymp1,
                        MoveDirection = FourWayDirection.Down,
                    }
                    .Start();
                    new SlideInEffect()
                    {
                        Widget = Enemymp2,
                        MoveDirection = FourWayDirection.Down,
                    }
                    .Start();
                    new SlideInEffect()
                    {
                        Widget = Enemymp3,
                        MoveDirection = FourWayDirection.Down,
                    }
                    .Start();
                    new SlideInEffect()
                    {
                        Widget = Enemympbar1,
                        MoveDirection = FourWayDirection.Down,
                    }
                    .Start();
                    new SlideInEffect()
                    {
                        Widget = Enemympbar2,
                        MoveDirection = FourWayDirection.Down,
                    }
                    .Start();
                    new SlideInEffect()
                    {
                        Widget = Enemympbar3,
                        MoveDirection = FourWayDirection.Down,
                    }
                    .Start();
                    new SlideInEffect()
                    {
                        Widget = Heromp1,
                        MoveDirection = FourWayDirection.Up,
                    }
                    .Start();
                    new SlideInEffect()
                    {
                        Widget = Heromp2,
                        MoveDirection = FourWayDirection.Up,
                    }
                    .Start();
                    new SlideInEffect()
                    {
                        Widget = Herompbar1,
                        MoveDirection = FourWayDirection.Up,
                    }
                    .Start();
                    new SlideInEffect()
                    {
                        Widget = Herompbar2,
                        MoveDirection = FourWayDirection.Up,
                    }
                    .Start();
                    new SlideInEffect()
                    {
                        Widget = Hero1Skilltop,
                        MoveDirection = FourWayDirection.Up,
                    }
                    .Start();
                    new SlideInEffect()
                    {
                        Widget = Hero1Skillleft,
                        MoveDirection = FourWayDirection.Up,
                    }
                    .Start();
                    new SlideInEffect()
                    {
                        Widget = Hero1Skillright,
                        MoveDirection = FourWayDirection.Up,
                    }
                    .Start();
                    new SlideInEffect()
                    {
                        Widget = Hero2Skilltop,
                        MoveDirection = FourWayDirection.Up,
                    }
                    .Start();
                    new SlideInEffect()
                    {
                        Widget = Hero2Skillleft,
                        MoveDirection = FourWayDirection.Up,
                    }
                    .Start();
                    new SlideInEffect()
                    {
                        Widget = Hero2Skillright,
                        MoveDirection = FourWayDirection.Up,
                    }
                    .Start();
                    new SlideInEffect()
                    {
                        Widget = enemy1_hpstats,
                        MoveDirection = FourWayDirection.Down,
                    }
                    .Start();
                    new SlideInEffect()
                    {
                        Widget = enemy1_mpstats,
                        MoveDirection = FourWayDirection.Down,
                    }
                    .Start();
                    new SlideInEffect()
                    {
                        Widget = enemy2_hpstats,
                        MoveDirection = FourWayDirection.Down,
                    }
                    .Start();
                    new SlideInEffect()
                    {
                        Widget = enemy2_mpstats,
                        MoveDirection = FourWayDirection.Down,
                    }
                    .Start();
                    new SlideInEffect()
                    {
                        Widget = enemy3_hpstats,
                        MoveDirection = FourWayDirection.Down,
                    }
                    .Start();
                    new SlideInEffect()
                    {
                        Widget = enemy3_mpstats,
                        MoveDirection = FourWayDirection.Down,
                    }
                    .Start();
                    new SlideInEffect()
                    {
                        Widget = HeroFrame2,
                        MoveDirection = FourWayDirection.Up,
                    }
                    .Start();
                    new SlideInEffect()
                    {
                        Widget = HeroFrame1,
                        MoveDirection = FourWayDirection.Up,
                    }
                    .Start();
                    new SlideInEffect()
                    {
                        Widget = hero2_hpstats,
                        MoveDirection = FourWayDirection.Up,
                    }
                    .Start();
                    new SlideInEffect()
                    {
                        Widget = hero1_mpstats,
                        MoveDirection = FourWayDirection.Up,
                    }
                    .Start();
                    new SlideInEffect()
                    {
                        Widget = hero2_mpstats,
                        MoveDirection = FourWayDirection.Up,
                    }
                    .Start();
                    new SlideInEffect()
                    {
                        Widget = hero1_hpstats,
                        MoveDirection = FourWayDirection.Up,
                    }
                    .Start();
                }
                break;

                default:
                {
                    new SlideInEffect()
                    {
                        Widget = EnemyFrame1,
                        MoveDirection = FourWayDirection.Down,
                    }
                    .Start();
                    new SlideInEffect()
                    {
                        Widget = EnemyFrame2,
                        MoveDirection = FourWayDirection.Down,
                    }
                    .Start();
                    new SlideInEffect()
                    {
                        Widget = EnemyFrame3,
                        MoveDirection = FourWayDirection.Down,
                    }
                    .Start();
                    new SlideInEffect()
                    {
                        Widget = btnHero1Skilltop,
                        MoveDirection = FourWayDirection.Up,
                    }
                    .Start();
                    new SlideInEffect()
                    {
                        Widget = btnHero1Skillleft,
                        MoveDirection = FourWayDirection.Up,
                    }
                    .Start();
                    new SlideInEffect()
                    {
                        Widget = btnHero1Skillright,
                        MoveDirection = FourWayDirection.Up,
                    }
                    .Start();
                    new SlideInEffect()
                    {
                        Widget = btnHero2Skilltop,
                        MoveDirection = FourWayDirection.Up,
                    }
                    .Start();
                    new SlideInEffect()
                    {
                        Widget = btnHero2Skillleft,
                        MoveDirection = FourWayDirection.Up,
                    }
                    .Start();
                    new SlideInEffect()
                    {
                        Widget = btnHero2Skillright,
                        MoveDirection = FourWayDirection.Up,
                    }
                    .Start();
                    new SlideInEffect()
                    {
                        Widget = EnemyPortrait1,
                        MoveDirection = FourWayDirection.Down,
                    }
                    .Start();
                    new SlideInEffect()
                    {
                        Widget = EnemyPortrait2,
                        MoveDirection = FourWayDirection.Down,
                    }
                    .Start();
                    new SlideInEffect()
                    {
                        Widget = EnemyPortrait3,
                        MoveDirection = FourWayDirection.Down,
                    }
                    .Start();
                    new SlideInEffect()
                    {
                        Widget = HeroPortrait1,
                        MoveDirection = FourWayDirection.Up,
                    }
                    .Start();
                    new SlideInEffect()
                    {
                        Widget = HeroPortrait2,
                        MoveDirection = FourWayDirection.Up,
                    }
                    .Start();
                    new FadeInEffect()
                    {
                        Widget = Background,
                    }
                    .Start();
                    new FadeInEffect()
                    {
                        Widget = EnemyBody1,
                    }
                    .Start();
                    new FadeInEffect()
                    {
                        Widget = EnemyBody2,
                    }
                    .Start();
                    new FadeInEffect()
                    {
                        Widget = EnemyBody3,
                    }
                    .Start();
                    new SlideInEffect()
                    {
                        Widget = Enemyhp1,
                        MoveDirection = FourWayDirection.Down,
                    }
                    .Start();
                    new SlideInEffect()
                    {
                        Widget = Enemyhp2,
                        MoveDirection = FourWayDirection.Down,
                    }
                    .Start();
                    new SlideInEffect()
                    {
                        Widget = Enemyhp3,
                        MoveDirection = FourWayDirection.Down,
                    }
                    .Start();
                    new SlideInEffect()
                    {
                        Widget = Enemyhpbar1,
                        MoveDirection = FourWayDirection.Down,
                    }
                    .Start();
                    new SlideInEffect()
                    {
                        Widget = Enemyhpbar2,
                        MoveDirection = FourWayDirection.Down,
                    }
                    .Start();
                    new SlideInEffect()
                    {
                        Widget = Enemyhpbar3,
                        MoveDirection = FourWayDirection.Down,
                    }
                    .Start();
                    new SlideInEffect()
                    {
                        Widget = Herohp1,
                        MoveDirection = FourWayDirection.Up,
                    }
                    .Start();
                    new SlideInEffect()
                    {
                        Widget = Herohp2,
                        MoveDirection = FourWayDirection.Up,
                    }
                    .Start();
                    new SlideInEffect()
                    {
                        Widget = Herohpbar1,
                        MoveDirection = FourWayDirection.Up,
                    }
                    .Start();
                    new SlideInEffect()
                    {
                        Widget = Herohpbar2,
                        MoveDirection = FourWayDirection.Up,
                    }
                    .Start();
                    new SlideInEffect()
                    {
                        Widget = Enemymp1,
                        MoveDirection = FourWayDirection.Down,
                    }
                    .Start();
                    new SlideInEffect()
                    {
                        Widget = Enemymp2,
                        MoveDirection = FourWayDirection.Down,
                    }
                    .Start();
                    new SlideInEffect()
                    {
                        Widget = Enemymp3,
                        MoveDirection = FourWayDirection.Down,
                    }
                    .Start();
                    new SlideInEffect()
                    {
                        Widget = Enemympbar1,
                        MoveDirection = FourWayDirection.Down,
                    }
                    .Start();
                    new SlideInEffect()
                    {
                        Widget = Enemympbar2,
                        MoveDirection = FourWayDirection.Down,
                    }
                    .Start();
                    new SlideInEffect()
                    {
                        Widget = Enemympbar3,
                        MoveDirection = FourWayDirection.Down,
                    }
                    .Start();
                    new SlideInEffect()
                    {
                        Widget = Heromp1,
                        MoveDirection = FourWayDirection.Up,
                    }
                    .Start();
                    new SlideInEffect()
                    {
                        Widget = Heromp2,
                        MoveDirection = FourWayDirection.Up,
                    }
                    .Start();
                    new SlideInEffect()
                    {
                        Widget = Herompbar1,
                        MoveDirection = FourWayDirection.Up,
                    }
                    .Start();
                    new SlideInEffect()
                    {
                        Widget = Herompbar2,
                        MoveDirection = FourWayDirection.Up,
                    }
                    .Start();
                    new SlideInEffect()
                    {
                        Widget = Hero1Skilltop,
                        MoveDirection = FourWayDirection.Up,
                    }
                    .Start();
                    new SlideInEffect()
                    {
                        Widget = Hero1Skillleft,
                        MoveDirection = FourWayDirection.Up,
                    }
                    .Start();
                    new SlideInEffect()
                    {
                        Widget = Hero1Skillright,
                        MoveDirection = FourWayDirection.Up,
                    }
                    .Start();
                    new SlideInEffect()
                    {
                        Widget = Hero2Skilltop,
                        MoveDirection = FourWayDirection.Up,
                    }
                    .Start();
                    new SlideInEffect()
                    {
                        Widget = Hero2Skillleft,
                        MoveDirection = FourWayDirection.Up,
                    }
                    .Start();
                    new SlideInEffect()
                    {
                        Widget = Hero2Skillright,
                        MoveDirection = FourWayDirection.Up,
                    }
                    .Start();
                    new SlideInEffect()
                    {
                        Widget = enemy1_hpstats,
                        MoveDirection = FourWayDirection.Down,
                    }
                    .Start();
                    new SlideInEffect()
                    {
                        Widget = enemy1_mpstats,
                        MoveDirection = FourWayDirection.Down,
                    }
                    .Start();
                    new SlideInEffect()
                    {
                        Widget = enemy2_hpstats,
                        MoveDirection = FourWayDirection.Down,
                    }
                    .Start();
                    new SlideInEffect()
                    {
                        Widget = enemy2_mpstats,
                        MoveDirection = FourWayDirection.Down,
                    }
                    .Start();
                    new SlideInEffect()
                    {
                        Widget = enemy3_hpstats,
                        MoveDirection = FourWayDirection.Down,
                    }
                    .Start();
                    new SlideInEffect()
                    {
                        Widget = enemy3_mpstats,
                        MoveDirection = FourWayDirection.Down,
                    }
                    .Start();
                    new SlideInEffect()
                    {
                        Widget = HeroFrame2,
                        MoveDirection = FourWayDirection.Up,
                    }
                    .Start();
                    new SlideInEffect()
                    {
                        Widget = HeroFrame1,
                        MoveDirection = FourWayDirection.Up,
                    }
                    .Start();
                    new SlideInEffect()
                    {
                        Widget = hero2_hpstats,
                        MoveDirection = FourWayDirection.Up,
                    }
                    .Start();
                    new SlideInEffect()
                    {
                        Widget = hero1_mpstats,
                        MoveDirection = FourWayDirection.Up,
                    }
                    .Start();
                    new SlideInEffect()
                    {
                        Widget = hero2_mpstats,
                        MoveDirection = FourWayDirection.Up,
                    }
                    .Start();
                    new SlideInEffect()
                    {
                        Widget = hero1_hpstats,
                        MoveDirection = FourWayDirection.Up,
                    }
                    .Start();
                }
                break;
            }
        }
    }
}
