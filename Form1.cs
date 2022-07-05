namespace DeadByDaylightRandomizer
{
    public partial class frmDeadByDaylightRandomizer : Form
    {
        public frmDeadByDaylightRandomizer()
        {
            InitializeComponent();
        }

        private void btnKiller_Click(object sender, EventArgs e)
        {
            string[] killers = { "The Trapper", "The Wraith", "The Hillbilly", "The Nurse", "The Shape", "The Hag", "The Doctor", "The Huntress", "The Cannibal", "The Nightmare", "The Pig", "The Clown", "The Spirit", "The Legion", "The Plague", "The Demogorgon", "The Ghost Face", "The Oni", "The Deathslinger", "The Executioner", "The Blight", "The Twins", "The Trickster", "The Nemesis", "The Cenobite", "The Artist", "The Onryo", "The Dredge" };
            Bitmap[] images = { Properties.Resources.trapper, Properties.Resources.wraith, Properties.Resources.hillbilly, Properties.Resources.nurse, Properties.Resources.myers, Properties.Resources.hag, Properties.Resources.doctor, Properties.Resources.huntress, Properties.Resources.bubba, Properties.Resources.freddy, Properties.Resources.pig, Properties.Resources.clown, Properties.Resources.spirit, Properties.Resources.legion, Properties.Resources.plague, Properties.Resources.demogorgon, Properties.Resources.ghostface, Properties.Resources.oni, Properties.Resources.deathslinger, Properties.Resources.pyramidhead, Properties.Resources.blight, Properties.Resources.twins, Properties.Resources.trickster, Properties.Resources.nemesis, Properties.Resources.pinhead, Properties.Resources.artist, Properties.Resources.sadako, Properties.Resources.dredge };

            Random rand = new Random();
            byte killer = (byte)rand.Next(killers.Length);

            lblKiller.Text = killers[killer];
            picKiller.Image = images[killer];
            GC.Collect();
        }

        private void btnPerks_Click(object sender, EventArgs e)
        {
            string[] perks = { "A Nurse's Calling", "Agitation", "Bamboozle", "Barbecue and Chili", "Beast of Prey", "Bitter Murmur", "Blood Echo", "Blood Warden", "Bloodhound", "Brutal Strength", "Call of Brine", "Corrupt Intervention", "Coulrophobia", "Coup de Grace", "Claustrophobia", "Dark Devotion", "Darkness Revealed", "Dead Man's Switch", "Deadlock", "Deathbound", "Deerstalker", "Discordance", "Dissolution", "Distressing", "Dragon's Grip", "Dying Light", "Enduring", "Eruption", "Fearmonger", "Fire Up", "Forced Penance", "Franklin's Demise", "Furtive Chase", "Gearhead", "Grim Embrace", "Hangman's Trick", "Hex: Blood Favour", "Hex: Crowd Control", "Hex: Devour Hope", "Hex: Haunted Ground", "Hex: Huntress Lullaby", "Hex: No One Escapes Death", "Hex: Pentimento", "Hex: Plaything", "Hex: Retribution", "Hex: Ruin", "Hex: The Third Seal", "Hex: Thrill of the Hunt", "Hex: Undying", "Hoarder", "Hysteria", "I'm All Ears", "Infectious Fright", "Insidious", "Iron Grasp", "Iron Maiden", "Jolt", "Knock Out", "Lethal Pursuer", "Lightborn", "Mad Grit", "Make Your Choice", "Merciless Storm", "Monitor and Abuse", "Nemesis", "No Way Out", "Oppression", "Overcharge", "Overwhelming Presence", "Play With Your Food", "Pop Goes the Weasel", "Predator", "Rancor", "Remember Me", "Save the Best for Last", "Scourge Hook: Floods of Rage", "Scourge Hook: Gift of Pain", "Scourge Hook: Monstrous Shrine", "Scourge Hook: Pain Resonance", "Septic Touch", "Shadowborn", "Shattered Hope", "Sloppy Butcher", "Spies From the Shadows", "Spirit Fury", "Starstruck", "Stridor", "Surveillance", "Territorial Imperative", "Thanatophobia", "Thrilling Tremors", "Tinkerer", "Trail of Torment", "Unnerving Presence", "Unrelenting", "Whispers", "Zanshin Tactics" };
            Bitmap[] icons = { Properties.Resources.aNursesCalling, Properties.Resources.agitation, Properties.Resources.bamboozle, Properties.Resources.bbq, Properties.Resources.beastOfPrey, Properties.Resources.bitterMurmur, Properties.Resources.bloodEcho, Properties.Resources.bloodWarden, Properties.Resources.bloodhound, Properties.Resources.brutalStrength, Properties.Resources.callOfBrine, Properties.Resources.corruptIntervention, Properties.Resources.coulrophobia, Properties.Resources.coupDeGrace, Properties.Resources.claustrophobia, Properties.Resources.darkDevotion, Properties.Resources.darknessRevealed, Properties.Resources.deadMansSwitch, Properties.Resources.deadlock, Properties.Resources.deathbound, Properties.Resources.deerstalker, Properties.Resources.discordance, Properties.Resources.dissolution, Properties.Resources.distressing, Properties.Resources.dragonsGrip, Properties.Resources.dyingLight, Properties.Resources.enduring, Properties.Resources.eruption, Properties.Resources.fearmonger, Properties.Resources.fireUp, Properties.Resources.forcedPenance, Properties.Resources.franklinsDemise, Properties.Resources.furtiveChase, Properties.Resources.gearhead, Properties.Resources.grimEmbrace, Properties.Resources.hangmansTrick, Properties.Resources.hexBloodFavour, Properties.Resources.hexCrowdControl, Properties.Resources.hexDevourHope, Properties.Resources.hexHauntedGround, Properties.Resources.hexHuntressLullaby, Properties.Resources.hexNoOneEscapesDeath, Properties.Resources.hexPentimento, Properties.Resources.hexPlaything, Properties.Resources.hexRetribution, Properties.Resources.hexRuin, Properties.Resources.hexTheThirdSeal, Properties.Resources.hexThrillOfTheHunt, Properties.Resources.hexUndying, Properties.Resources.hoarder, Properties.Resources.hysteria, Properties.Resources.imAllEars, Properties.Resources.infectiousFright, Properties.Resources.insidious, Properties.Resources.ironGrasp, Properties.Resources.ironMaiden, Properties.Resources.jolt, Properties.Resources.knockOut, Properties.Resources.lethalPursuer, Properties.Resources.lightborn, Properties.Resources.madGrit, Properties.Resources.makeYourChoice, Properties.Resources.mercilessStorm, Properties.Resources.monitorAndAbuse, Properties.Resources.nemesis1, Properties.Resources.noWayOut, Properties.Resources.oppression, Properties.Resources.overcharge, Properties.Resources.overwhelmingPresence, Properties.Resources.playWithYourFood, Properties.Resources.popGoesTheWeasel, Properties.Resources.predator, Properties.Resources.rancor, Properties.Resources.rememberMe, Properties.Resources.saveTheBestForLast, Properties.Resources.scourgeHookFloodsOfRage, Properties.Resources.scourgeHookGiftOfPain, Properties.Resources.scourgeHookMonstrousShrine, Properties.Resources.scourgeHookPainResonance, Properties.Resources.septicTouch, Properties.Resources.shadowborn, Properties.Resources.shatteredHope, Properties.Resources.sloppyButcher, Properties.Resources.spiesFromTheShadows, Properties.Resources.spiritFury, Properties.Resources.starstruck, Properties.Resources.stridor, Properties.Resources.surveillance, Properties.Resources.territorialImperative, Properties.Resources.thanatophobia, Properties.Resources.thrillingTremors, Properties.Resources.tinkerer, Properties.Resources.trailOfTorment, Properties.Resources.unnervingPresence, Properties.Resources.unrelenting, Properties.Resources.whispers, Properties.Resources.zanshinTactics };
            Random random = new Random();

            byte perk = (byte)random.Next(perks.Length);
            lblPerkOne.Text = perks[perk];
            picPerkOne.Image = icons[perk];

            do
            {
                perk = (byte)random.Next(perks.Length);
                lblPerkTwo.Text = perks[perk];
                picPerkTwo.Image = icons[perk];
            } while (lblPerkTwo.Text == lblPerkOne.Text);

            do
            {
                perk = (byte)random.Next(perks.Length);
                lblPerkThree.Text = perks[perk];
                picPerkThree.Image = icons[perk];
            } while (lblPerkThree.Text == lblPerkOne.Text || lblPerkThree.Text == lblPerkTwo.Text);

            do
            {
                perk = (byte)random.Next(perks.Length);
                lblPerkFour.Text = perks[perk];
                picPerkFour.Image = icons[perk];
            } while (lblPerkFour.Text == lblPerkOne.Text || lblPerkFour.Text == lblPerkTwo.Text || lblPerkFour.Text == lblPerkThree.Text);

            GC.Collect();
        }
    }
}