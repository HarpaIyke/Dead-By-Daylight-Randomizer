namespace DeadByDaylightRandomiser
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKiller_Click(object sender, EventArgs e)
        {
            string[] killers = {"The Trapper", "The Wraith", "The Hillbilly", "The Nurse", "The Shape", "The Hag", "The Doctor", "The Huntress", "The Cannibal", "The Nightmare", "The Pig", "The Clown", "The Spirit", "The Legion", "The Plague", "The Demogorgon", "The Ghost Face", "The Oni", "The Deathslinger", "The Executioner", "The Blight", "The Twins", "The Trickster", "The Nemesis", "The Cenobite", "The Artist", "The Onryo", "The Dredge" };
            Bitmap[] images = { Properties.Resources.trapper, Properties.Resources.wraith, Properties.Resources.hillbilly, Properties.Resources.nurse, Properties.Resources.myers, Properties.Resources.hag, Properties.Resources.doctor, Properties.Resources.huntress, Properties.Resources.bubba, Properties.Resources.freddy, Properties.Resources.pig, Properties.Resources.clown, Properties.Resources.spirit, Properties.Resources.legion, Properties.Resources.plague, Properties.Resources.demogorgon, Properties.Resources.ghostface, Properties.Resources.oni, Properties.Resources.deathslinger, Properties.Resources.pyramidhead, Properties.Resources.blight, Properties.Resources.twins, Properties.Resources.trickster, Properties.Resources.nemesis, Properties.Resources.pinhead, Properties.Resources.artist, Properties.Resources.sadako, Properties.Resources.dredge };

            Random rand = new Random();
            int killer = rand.Next(killers.Length);

            lblKiller.Text = killers[killer];
            picKiller.Image = images[killer];


        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            if (picPerkOne.Visible == false)
            {
                picPerkOne.Visible = true;
                picPerkTwo.Visible = true;
                picPerkThree.Visible = true;
                picPerkFour.Visible = true;
                lblPerkOne.Visible = true;
                lblPerkTwo.Visible = true;
                lblPerkThree.Visible = true;
                lblPerkFour.Visible = true;
            }
            else
            {
                picPerkOne.Visible = false;
                picPerkTwo.Visible = false;
                picPerkThree.Visible = false;
                picPerkFour.Visible = false;
                lblPerkOne.Visible = false;
                lblPerkTwo.Visible = false;
                lblPerkThree.Visible = false;
                lblPerkFour.Visible = false;
            }
               
        }

        private void btnPerks_Click(object sender, EventArgs e)
        {
            string[] perks = { "A Nurse's Calling", "Agitation", "Bamboozle", "Barbecue and Chili", "Beast of Prey", "Bitter Murmur", "Blood Echo", "Blood Warden", "Bloodhound", "Brutal Strength", "Call of Brine", "Corrupt Intervention", "Coulrophobia", "Coup de Grace", "Claustrophobia", "Dark Devotion", "Darkness Revealed", "Dead Man's Switch", "Deadlock", "Deathbound", "Deerstalker", "Discordance", "Dissolution", "Distressing", "Dragon's Grip", "Dying Light", "Enduring", "Eruption", "Fearmonger", "Fire Up", "Forced Penance", "Franklin's Demise", "Furtive Chase", "Gearhead", "Grim Embrace", "Hangman's Trick", "Hex: Blood Favour", "Hex: Crowd Control", "Hex: Devour Hope", "Hex: Haunted Ground", "Hex: Huntress Lullaby", "Hex: No One Escapes Death", "Hex: Pentimento", "Hex: Plaything", "Hex: Retribution", "Hex: Ruin", "Hex: The Third Seal", "Hex: Thrill of the Hunt", "Hex: Undying", "Hoarder", "Hysteria", "I'm All Ears", "Infectious Fright", "Insidious", "Iron Grasp", "Iron Maiden", "Jolt", "Knock Out", "Lethal Pursuer", "Lightborn", "Mad Grit", "Make Your Choice", "Merciless Storm", "Monitor and Abuse", "Nemesis", "No Way Out", "Oppression", "Overcharge", "Overwhelming Presence", "Play With Your Food", "Pop Goes the Weasel", "Predator", "Rancor", "Remember Me", "Save the Best for Last", "Scourge Hook: Floods of Rage", "Scourge Hook: Gift of Pain", "Scourge Hook: Monstrous Shrine", "Scourge Hook: Pain Resonance", "Septic Touch", "Shadowborn", "Shattered Hope", "Sloppy Butcher", "Spies From the Shadows", "Spirit Fury", "Starstruck", "Stridor", "Surveillance", "Territorial Imperative", "Thanatophobia", "Thrilling Tremors", "Tinkerer", "Trail of Torment", "Unnerving Presence", "Unrelenting", "Whispers", "Zenshin Tactics" };
            string[] icons = { "https://static.wikia.nocookie.net/deadbydaylight_gamepedia_en/images/f/fe/IconPerks_aNursesCalling.png/revision/latest/scale-to-width-down/100?cb=20160820090103", "https://static.wikia.nocookie.net/deadbydaylight_gamepedia_en/images/a/ac/IconPerks_agitation.png/revision/latest/scale-to-width-down/100?cb=20160605204807", "https://static.wikia.nocookie.net/deadbydaylight_gamepedia_en/images/7/7a/IconPerks_bamboozle.png/revision/latest/scale-to-width-down/100?cb=20180529205216", "https://static.wikia.nocookie.net/deadbydaylight_gamepedia_en/images/5/51/IconPerks_barbecueAndChilli.png/revision/latest/scale-to-width-down/100?cb=20170914173637", "https://static.wikia.nocookie.net/deadbydaylight_gamepedia_en/images/7/77/IconPerks_beastOfPrey.png/revision/latest/scale-to-width-down/100?cb=20170727160820", "https://static.wikia.nocookie.net/deadbydaylight_gamepedia_en/images/5/5a/IconPerks_bitterMurmur.png/revision/latest/scale-to-width-down/100?cb=20160605204819", "https://static.wikia.nocookie.net/deadbydaylight_gamepedia_en/images/c/c3/IconPerks_bloodEcho.png/revision/latest/scale-to-width-down/100?cb=20191126213547", "https://static.wikia.nocookie.net/deadbydaylight_gamepedia_en/images/e/eb/IconPerks_bloodWarden.png/revision/latest/scale-to-width-down/100?cb=20171026225711", "https://static.wikia.nocookie.net/deadbydaylight_gamepedia_en/images/e/e0/IconPerks_bloodhound.png/revision/latest/scale-to-width-down/100?cb=20160605204825", "https://static.wikia.nocookie.net/deadbydaylight_gamepedia_en/images/3/3d/IconPerks_brutalStrength.png/revision/latest/scale-to-width-down/100?cb=20160605204842", "https://static.wikia.nocookie.net/deadbydaylight_gamepedia_en/images/3/3b/IconPerks_callOfBrine.png/revision/latest/scale-to-width-down/100?cb=20220216115938", "https://static.wikia.nocookie.net/deadbydaylight_gamepedia_en/images/1/10/IconPerks_corruptIntervention.png/revision/latest/scale-to-width-down/100?cb=20190306195826", "https://static.wikia.nocookie.net/deadbydaylight_gamepedia_en/images/4/45/IconPerks_coulrophobia.png/revision/latest/scale-to-width-down/100?cb=20180529205206", "https://static.wikia.nocookie.net/deadbydaylight_gamepedia_en/images/b/bd/IconPerks_coupDeGr%C3%A2ce.png/revision/latest/scale-to-width-down/100?cb=20201112095015", "https://static.wikia.nocookie.net/deadbydaylight_gamepedia_en/images/c/c6/IconPerks_cruelLimits.png/revision/latest/scale-to-width-down/100?cb=20190903175111", "https://static.wikia.nocookie.net/deadbydaylight_gamepedia_en/images/4/4f/IconPerks_darkDevotion.png/revision/latest/scale-to-width-down/100?cb=20190306195813", "https://static.wikia.nocookie.net/deadbydaylight_gamepedia_en/images/e/ed/IconPerks_darknessRevealed.png/revision/latest/scale-to-width-down/100?cb=20220518112818", "https://static.wikia.nocookie.net/deadbydaylight_gamepedia_en/images/c/c3/IconPerks_deadMansSwitch.png/revision/latest/scale-to-width-down/100?cb=20200218172942", "https://static.wikia.nocookie.net/deadbydaylight_gamepedia_en/images/d/d3/IconPerks_deadlock.png/revision/latest/scale-to-width-down/100?cb=20210819105650", "https://static.wikia.nocookie.net/deadbydaylight_gamepedia_en/images/e/e7/IconPerks_deathbound.png/revision/latest/scale-to-width-down/100?cb=20200526201504", "https://static.wikia.nocookie.net/deadbydaylight_gamepedia_en/images/0/01/IconPerks_deerstalker.png/revision/latest/scale-to-width-down/100?cb=20160605204859", "https://static.wikia.nocookie.net/deadbydaylight_gamepedia_en/images/8/82/IconPerks_discordance.png/revision/latest/scale-to-width-down/100?cb=20181128100920", "https://static.wikia.nocookie.net/deadbydaylight_gamepedia_en/images/1/1d/IconPerks_dissolution.png/revision/latest/scale-to-width-down/100?cb=20220518112819", "https://static.wikia.nocookie.net/deadbydaylight_gamepedia_en/images/9/94/IconPerks_distressing.png/revision/latest/scale-to-width-down/100?cb=20160605204911", "https://static.wikia.nocookie.net/deadbydaylight_gamepedia_en/images/f/ff/IconPerks_dragonsGrip.png/revision/latest/scale-to-width-down/100?cb=20200819113412", "https://static.wikia.nocookie.net/deadbydaylight_gamepedia_en/images/4/48/IconPerks_dyingLight.png/revision/latest/scale-to-width-down/100?cb=20161023113257", "https://static.wikia.nocookie.net/deadbydaylight_gamepedia_en/images/9/94/IconPerks_enduring.png/revision/latest/scale-to-width-down/100?cb=20160605204922", "https://static.wikia.nocookie.net/deadbydaylight_gamepedia_en/images/d/dd/IconPerks_eruption.png/revision/latest/scale-to-width-down/100?cb=20210526102859", "https://static.wikia.nocookie.net/deadbydaylight_gamepedia_en/images/0/0f/IconPerks_mindbreaker.png/revision/latest/scale-to-width-down/100?cb=20190903175217", "https://static.wikia.nocookie.net/deadbydaylight_gamepedia_en/images/5/5c/IconPerks_fireUp.png/revision/latest/scale-to-width-down/100?cb=20171026225645", "https://static.wikia.nocookie.net/deadbydaylight_gamepedia_en/images/1/1d/IconPerks_forcedPenance.png/revision/latest/scale-to-width-down/100?cb=20200526201518", "https://static.wikia.nocookie.net/deadbydaylight_gamepedia_en/images/b/b2/IconPerks_franklinsDemise.png/revision/latest/scale-to-width-down/100?cb=20170914173626", "https://static.wikia.nocookie.net/deadbydaylight_gamepedia_en/images/9/94/IconPerks_furtiveChase.png/revision/latest/scale-to-width-down/100?cb=20190606094409", "https://static.wikia.nocookie.net/deadbydaylight_gamepedia_en/images/f/fd/IconPerks_gearhead.png/revision/latest/scale-to-width-down/100?cb=20200218172900", "https://static.wikia.nocookie.net/deadbydaylight_gamepedia_en/images/1/1c/IconPerks_grimEmbrace.png/revision/latest/scale-to-width-down/100?cb=20211109180734", "https://static.wikia.nocookie.net/deadbydaylight_gamepedia_en/images/b/b4/IconPerks_hangmansTrick.png/revision/latest/scale-to-width-down/100?cb=20180123224254", "https://static.wikia.nocookie.net/deadbydaylight_gamepedia_en/images/6/6b/IconPerks_hexBloodFavour.png/revision/latest/scale-to-width-down/100?cb=20200819113451", "https://static.wikia.nocookie.net/deadbydaylight_gamepedia_en/images/f/f1/IconPerks_hexCrowdControl.png/revision/latest/scale-to-width-down/100?cb=20210302172300", "https://static.wikia.nocookie.net/deadbydaylight_gamepedia_en/images/c/c9/IconPerks_hexDevourHope.png/revision/latest/scale-to-width-down/100?cb=20161209192341", "https://static.wikia.nocookie.net/deadbydaylight_gamepedia_en/images/c/c4/IconPerks_hexHauntedGround.png/revision/latest/scale-to-width-down/100?cb=20180828172944", "https://static.wikia.nocookie.net/deadbydaylight_gamepedia_en/images/1/11/IconPerks_hexHuntressLullaby.png/revision/latest/scale-to-width-down/100?cb=20170727160900", "https://static.wikia.nocookie.net/deadbydaylight_gamepedia_en/images/a/af/IconPerks_hexNoOneEscapesDeath.png/revision/latest/scale-to-width-down/100?cb=20160605205020", "https://static.wikia.nocookie.net/deadbydaylight_gamepedia_en/images/5/5d/IconPerks_hexPentimento.png/revision/latest/scale-to-width-down/100?cb=20211109175002", "https://static.wikia.nocookie.net/deadbydaylight_gamepedia_en/images/1/18/IconPerks_hexPlaything.png/revision/latest/scale-to-width-down/100?cb=20210819105650", "https://static.wikia.nocookie.net/deadbydaylight_gamepedia_en/images/a/ab/IconPerks_hexRetribution.png/revision/latest/scale-to-width-down/100?cb=20200218172811", "https://static.wikia.nocookie.net/deadbydaylight_gamepedia_en/images/a/a2/IconPerks_hexRuin.png/revision/latest/scale-to-width-down/100?cb=20161209193143", "https://static.wikia.nocookie.net/deadbydaylight_gamepedia_en/images/3/36/IconPerks_hexTheThirdSeal.png/revision/latest/scale-to-width-down/100?cb=20161210091328", "https://static.wikia.nocookie.net/deadbydaylight_gamepedia_en/images/0/02/IconPerks_hexThrillOfTheHunt.png/revision/latest/scale-to-width-down/100?cb=20161210091341", "https://static.wikia.nocookie.net/deadbydaylight_gamepedia_en/images/f/fe/IconPerks_hexUndying.png/revision/latest/scale-to-width-down/100?cb=20200819113555", "https://static.wikia.nocookie.net/deadbydaylight_gamepedia_en/images/2/23/IconPerks_hoarder.png/revision/latest/scale-to-width-down/100?cb=20201112100327", "https://static.wikia.nocookie.net/deadbydaylight_gamepedia_en/images/3/3a/IconPerks_hysteria.png/revision/latest/scale-to-width-down/100?cb=20210526103043", "https://static.wikia.nocookie.net/deadbydaylight_gamepedia_en/images/e/e3/IconPerks_imAllEars.png/revision/latest/scale-to-width-down/100?cb=20190606094404", "https://static.wikia.nocookie.net/deadbydaylight_gamepedia_en/images/6/6d/IconPerks_infectiousFright.png/revision/latest/scale-to-width-down/100?cb=20190306195819", "https://static.wikia.nocookie.net/deadbydaylight_gamepedia_en/images/4/40/IconPerks_insidious.png/revision/latest/scale-to-width-down/100?cb=20160605204933", "https://static.wikia.nocookie.net/deadbydaylight_gamepedia_en/images/1/14/IconPerks_ironGrasp.png/revision/latest/scale-to-width-down/100?cb=20160605204939", "https://static.wikia.nocookie.net/deadbydaylight_gamepedia_en/images/b/b0/IconPerks_ironMaiden.png/revision/latest/scale-to-width-down/100?cb=20181128100910", "https://static.wikia.nocookie.net/deadbydaylight_gamepedia_en/images/3/3b/IconPerks_surge.png/revision/latest/scale-to-width-down/100?cb=20190903175259", "https://static.wikia.nocookie.net/deadbydaylight_gamepedia_en/images/5/52/IconPerks_knockOut.png/revision/latest/scale-to-width-down/100?cb=20170914173607", "https://static.wikia.nocookie.net/deadbydaylight_gamepedia_en/images/6/61/IconPerks_lethalPursuer.png/revision/latest/scale-to-width-down/100?cb=20210526103144", "https://static.wikia.nocookie.net/deadbydaylight_gamepedia_en/images/4/48/IconPerks_lightborn.png/revision/latest/scale-to-width-down/100?cb=20160605205002", "https://static.wikia.nocookie.net/deadbydaylight_gamepedia_en/images/d/da/IconPerks_madGrit.png/revision/latest/scale-to-width-down/100?cb=20181128100906", "https://static.wikia.nocookie.net/deadbydaylight_gamepedia_en/images/6/6b/IconPerks_makeYourChoice.png/revision/latest/scale-to-width-down/100?cb=20180123224326", "https://static.wikia.nocookie.net/deadbydaylight_gamepedia_en/images/3/36/IconPerks_mercilessStorm.png/revision/latest/scale-to-width-down/100?cb=20220216120012", "https://static.wikia.nocookie.net/deadbydaylight_gamepedia_en/images/6/60/IconPerks_monitorAndAbuse.png/revision/latest/scale-to-width-down/100?cb=20170511153248", "https://static.wikia.nocookie.net/deadbydaylight_gamepedia_en/images/3/33/IconPerks_nemesis.png/revision/latest/scale-to-width-down/100?cb=20191126213602", "https://static.wikia.nocookie.net/deadbydaylight_gamepedia_en/images/b/bb/IconPerks_noWayOut.png/revision/latest/scale-to-width-down/100?cb=20210302172337", "https://static.wikia.nocookie.net/deadbydaylight_gamepedia_en/images/a/a1/IconPerks_oppression.png/revision/latest/scale-to-width-down/100?cb=20201112095043", "https://static.wikia.nocookie.net/deadbydaylight_gamepedia_en/images/c/c3/IconPerks_overcharge.png/revision/latest/scale-to-width-down/100?cb=20170511153315", "https://static.wikia.nocookie.net/deadbydaylight_gamepedia_en/images/9/9a/IconPerks_overwhelmingPresence.png/revision/latest/scale-to-width-down/100?cb=20170511153235", "https://static.wikia.nocookie.net/deadbydaylight_gamepedia_en/images/1/18/IconPerks_playWithYourFood.png/revision/latest/scale-to-width-down/100?cb=20161023113758", "https://static.wikia.nocookie.net/deadbydaylight_gamepedia_en/images/0/0f/IconPerks_popGoesTheWeasel.png/revision/latest/scale-to-width-down/100?cb=20180529205138", "https://static.wikia.nocookie.net/deadbydaylight_gamepedia_en/images/7/73/IconPerks_predator.png/revision/latest/scale-to-width-down/100?cb=20160605205037", "https://static.wikia.nocookie.net/deadbydaylight_gamepedia_en/images/a/a2/IconPerks_rancor.png/revision/latest/scale-to-width-down/100?cb=20180828172949", "https://static.wikia.nocookie.net/deadbydaylight_gamepedia_en/images/6/62/IconPerks_rememberMe.png/revision/latest/scale-to-width-down/100?cb=20171026225659", "https://static.wikia.nocookie.net/deadbydaylight_gamepedia_en/images/6/6a/IconPerks_saveTheBestForLast.png/revision/latest?cb=20161023113950", "https://static.wikia.nocookie.net/deadbydaylight_gamepedia_en/images/1/1c/IconPerks_scourgeHookFloodsOfRage.png/revision/latest/scale-to-width-down/100?cb=20220216120003", "https://static.wikia.nocookie.net/deadbydaylight_gamepedia_en/images/2/26/IconPerks_scourgeHookGiftOfPain.png/revision/latest/scale-to-width-down/100?cb=20210819105650", "https://static.wikia.nocookie.net/deadbydaylight_gamepedia_en/images/9/91/IconPerks_scourgeHookMonstrousShrine.png/revision/latest/scale-to-width-down/100?cb=20160605205014", "https://static.wikia.nocookie.net/deadbydaylight_gamepedia_en/images/7/79/IconPerks_scourgeHookPainResonance.png/revision/latest/scale-to-width-down/100?cb=20211109180802", "https://static.wikia.nocookie.net/deadbydaylight_gamepedia_en/images/d/d8/IconPerks_septicTouch.png/revision/latest/scale-to-width-down/100?cb=20220518112819", "https://static.wikia.nocookie.net/deadbydaylight_gamepedia_en/images/a/ac/IconPerks_shadowborn.png/revision/latest/scale-to-width-down/100?cb=20160605205118", "https://static.wikia.nocookie.net/deadbydaylight_gamepedia_en/images/a/aa/IconPerks_shatteredHope.png/revision/latest/scale-to-width-down/100?cb=20220518112819", "https://static.wikia.nocookie.net/deadbydaylight_gamepedia_en/images/5/5a/IconPerks_sloppyButcher.png/revision/latest/scale-to-width-down/100?cb=20160605205130", "https://static.wikia.nocookie.net/deadbydaylight_gamepedia_en/images/b/b1/IconPerks_spiesFromTheShadows.png/revision/latest/scale-to-width-down/100?cb=20160605205141", "https://static.wikia.nocookie.net/deadbydaylight_gamepedia_en/images/a/a6/IconPerks_spiritFury.png/revision/latest/scale-to-width-down/100?cb=20180828172940", "https://static.wikia.nocookie.net/deadbydaylight_gamepedia_en/images/6/6e/IconPerks_starstruck.png/revision/latest/scale-to-width-down/100?cb=20210302172426", "https://static.wikia.nocookie.net/deadbydaylight_gamepedia_en/images/3/32/IconPerks_stridor.png/revision/latest/scale-to-width-down/100?cb=20160820085653", "https://static.wikia.nocookie.net/deadbydaylight_gamepedia_en/images/e/eb/IconPerks_surveillance.png/revision/latest/scale-to-width-down/100?cb=20180123224351", "https://static.wikia.nocookie.net/deadbydaylight_gamepedia_en/images/2/2a/IconPerks_territorialImperative.png/revision/latest/scale-to-width-down/100?cb=20170727160846", "https://static.wikia.nocookie.net/deadbydaylight_gamepedia_en/images/a/a2/IconPerks_thanatophobia.png/revision/latest/scale-to-width-down/100?cb=20160820090639", "https://static.wikia.nocookie.net/deadbydaylight_gamepedia_en/images/b/b8/IconPerks_thrillingTremors.png/revision/latest/scale-to-width-down/100?cb=20190606094359", "https://static.wikia.nocookie.net/deadbydaylight_gamepedia_en/images/d/d9/IconPerks_tinkerer.png/revision/latest/scale-to-width-down/100?cb=20160605205204", "https://static.wikia.nocookie.net/deadbydaylight_gamepedia_en/images/9/94/IconPerks_trailOfTorment.png/revision/latest/scale-to-width-down/100?cb=20200526201821", "https://static.wikia.nocookie.net/deadbydaylight_gamepedia_en/images/a/a4/IconPerks_unnervingPresence.png/revision/latest/scale-to-width-down/100?cb=20160605205217", "https://static.wikia.nocookie.net/deadbydaylight_gamepedia_en/images/5/57/IconPerks_unrelenting.png/revision/latest/scale-to-width-down/100?cb=20160605205223", "https://static.wikia.nocookie.net/deadbydaylight_gamepedia_en/images/b/bb/IconPerks_whispers.png/revision/latest/scale-to-width-down/100?cb=20160605205234", "https://static.wikia.nocookie.net/deadbydaylight_gamepedia_en/images/d/d3/IconPerks_zanshinTactics.png/revision/latest/scale-to-width-down/100?cb=20191126213608" };
            Random random = new Random();

            int perk = random.Next(perks.Length);
            lblPerkOne.Text = perks[perk];
            picPerkOne.ImageLocation = icons[perk];

            do
            {
                perk = random.Next(perks.Length);
                lblPerkTwo.Text = perks[perk];
                picPerkTwo.ImageLocation = icons[perk];
            } while (lblPerkTwo.Text == lblPerkOne.Text);  
                
            do
            {
                perk = random.Next(perks.Length);
                lblPerkThree.Text = perks[perk];
                picPerkThree.ImageLocation = icons[perk];
            } while (lblPerkThree.Text == lblPerkOne.Text || lblPerkThree.Text == lblPerkTwo.Text);

            do
            {
                perk = random.Next(perks.Length);
                lblPerkFour.Text = perks[perk];
                picPerkFour.ImageLocation = icons[perk];
            } while (lblPerkFour.Text == lblPerkOne.Text || lblPerkFour.Text == lblPerkTwo.Text || lblPerkFour.Text == lblPerkThree.Text);
        }
    }
}