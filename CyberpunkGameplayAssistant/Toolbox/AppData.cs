using CyberpunkGameplayAssistant.Models;
using CyberpunkGameplayAssistant.Toolbox.ExtensionMethods;
using CyberpunkGameplayAssistant.ViewModels;
using CyberpunkGameplayAssistant.Windows;
using System;
using System.Collections.Generic;
using System.Windows;

namespace CyberpunkGameplayAssistant.Toolbox
{
    public static class AppData
    {
        // Utility
        public static bool IsLoaded = false;
        public const bool DebugMode = true;
        public static MainViewModel MainModelRef;
        public static MainWindow WindowRef;
        public static FrameworkElement Framework = new();
        public static Random RNG = new();
        public static readonly string[] Alphabet = { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };
        public static readonly string[] Vowels = { "A", "E", "I", "O", "U" };

        // Other
        public static readonly DateTime DefaultDate = new(2045, 1, 1);
        public const string ShortDateFormat = "yyyy.MM.dd hh:mm";
        public const string LongDateFormat = "D";

        // File Format Filters
        public const string FilterImageFiles = "Image Files |*.png;*.jpg;*.gif;*.bmp";

        // Directories
        public static readonly string CurrentDirectory = $"{Environment.CurrentDirectory}/";
        public static readonly string DataDirectory = $"{CurrentDirectory}Data/";
        public static readonly string ResourcesDirectory = $"{CurrentDirectory}Resources/";
        public static readonly string CombatantImageDirectory = $"{ResourcesDirectory}Combatants/";
        public static readonly string ProgramImageDirectory = $"{ResourcesDirectory}Programs/";
        public static readonly string NpcImageDirectory = $"{DataDirectory}NpcImages/";
        public static readonly string PlayerImageDirectory = $"{DataDirectory}PlayerImages/";
        public static readonly string[] Directories = new string[] { 
            DataDirectory, ResourcesDirectory, CombatantImageDirectory, 
            ProgramImageDirectory, NpcImageDirectory, PlayerImageDirectory };

        // File Locations
        public const string File_Log = "log.txt";
        public static readonly string File_CampaignData = $"{DataDirectory}Campaigns.xml";
        public static readonly string File_CombatantData = $"{DataDirectory}Combatants.xml";

        // Combatant Types
        public const string ComTypeStandard = "Standard";
        public const string Player = "Player";
        public const string NPC = "NPC";
        public const string BlackIce = "Black ICE";
        public const string Demon = "Demon";
        public const string ActiveDefense = "Active Defense";
        public const string EmplacedDefense = "Emplaced Defense";

        // Combatant Classifications
        public const string ComClassCivilian = "Civilian";
        public const string ComClassLightGanger = "Light Ganger";
        public const string ComClassMediumGanger = "Medium Ganger";
        public const string ComClassHeavyGanger = "Heavy Ganger";
        public const string ComClassLightPolice = "Light Police";
        public const string ComClassMediumPolice = "Medium Police";
        public const string ComClassHeavyPolice = "Heavy Police";
        public const string ComClassLightCorpo = "Light Corpo";
        public const string ComClassMediumCorpo = "Medium Corpo";
        public const string ComClassHeavyCorpo = "Heavy Corpo";

        // Program Types
        public const string AntiPersonnelBlackIce = "Anti-Personnel Black ICE";
        public const string AntiProgramBlackIce = "Anti-Program Black ICE";

        // NET Architecture Difficulties
        public const string NetArchitectureDifficultyBasic = "Basic";
        public const string NetArchitectureDifficultyStandard = "Standard";
        public const string NetArchitectureDifficultyUncommon = "Uncommon";
        public const string NetArchitectureDifficultyAdvanced = "Advanced";

        // MultiObject Select Modes
        public const string MultiModeEnemies = "Enemies";
        public const string MultiModeCriticalInjuries = "Critical Injuries";

        // Gameplay Message Types
        public const string MessageOther = "Other";
        public const string MessageBlackIceStat = "Black Ice";
        public const string MessageCoinFllip = "Coin Flip";
        public const string MessageGmRoll = "GM Roll";
        public const string MessageInitiative = "Initiative";
        public const string MessageLoot = "Loot";
        public const string MessageReload = "Reload";
        public const string MessageSkillCheck = "Skill Check";
        public const string MessageStandardAction = "Standard Action";
        public const string MessageStatCheck = "Stat Check";
        public const string MessageWeaponAttack = "Weapon Attack";

        // Price Categories
        public const int PriceCheap = 10;
        public const int PriceEveryday = 20;
        public const int PriceCostly = 50;
        public const int PricePremium = 100;
        public const int PriceExpensive = 500;
        public const int PriceVeryExpensive = 1000;
        public const int PriceLuxury = 5000;
        public const int PriceSuperLuxury = 10000;

        // Alert Types
        public const string AlertError = "ERROR";
        public const string AlertInfo = "INFO";

        // Error Messages
        public const string ErrorNoAcceptableAmmoTypeInInventory = "Acceptable ammo type not found in combatant's inventory";
        public const string ErrorNoDemonAvailableForActiveDefense = "No Demon available to run this Active Defense.";
        public const string ErrorNotAnAutofireWeapon = "This weapon does not have Autofire";
        public const string ErrorNotEnoughWeaponOptions = "Not enough weapon options for this combatant to fulfill the number of options allowed";

        // Image Locations - Combatants
        private const string ImageBase = "/Resources/Combatants/";
        public const string PortraitDefault = $"{ImageBase}RED.png";
        // Image Locations - Black ICE
        private const string BlackIceBase = "/Resources/BlackIce/";
        private const string PortraitAsp = $"{BlackIceBase}Asp.png";
        private const string PortraitDragon = $"{BlackIceBase}Dragon.png";
        private const string PortraitGiant = $"{BlackIceBase}Giant.png";
        private const string PortraitHellhound = $"{BlackIceBase}Hellhound.png";
        private const string PortraitKiller = $"{BlackIceBase}Killer.png";
        private const string PortraitKraken = $"{BlackIceBase}Kraken.png";
        private const string PortraitLiche = $"{BlackIceBase}Liche.png";
        private const string PortraitRaven = $"{BlackIceBase}Raven.png";
        private const string PortraitSabertooth = $"{BlackIceBase}Sabertooth.png";
        private const string PortraitScorpion = $"{BlackIceBase}Scorpion.png";
        private const string PortraitSkunk = $"{BlackIceBase}Skunk.png";
        private const string PortraitWisp = $"{BlackIceBase}Wisp.png";
        // Image Locations - Demons
        private const string DemonBase = "/Resources/Demons/";
        private const string PortraitImp = $"{DemonBase}Imp.png";
        private const string PortraitEfreet = $"{DemonBase}Efreet.png";
        private const string PortraitBalron = $"{DemonBase}Balron.png";

        // Audio Locations
        private static readonly string AudioBase = $"{CurrentDirectory}Resources/Audio/";
        public static readonly string AudioAutofire = $"{AudioBase}Autofire.mp3"; //https://freesound.org/people/EFlexMusic/sounds/393671/
        public static readonly string AudioBow = $"{AudioBase}Bow.mp3"; //https://freesound.org/people/Erdie/sounds/65733/
        public static readonly string AudioDeepGunshot = $"{AudioBase}DeepGunshot.mp3"; //https://freesound.org/people/FilmmakersManual/sounds/522282/
        public static readonly string AudioExplosion = $"{AudioBase}Explosion.mp3"; //https://freesound.org/people/newlocknew/sounds/588386/
        public static readonly string AudioGunshot = $"{AudioBase}Gunshot.mp3"; //https://freesound.org/people/michorvath/sounds/427595/
        public static readonly string AudioMalfunction = $"{AudioBase}Malfunction.mp3"; //https://freesound.org/people/gristi/sounds/562198/
        public static readonly string AudioMelee = $"{AudioBase}Melee.mp3"; //https://freesound.org/people/Kreastricon62/sounds/550378/
        public static readonly string AudioReload = $"{AudioBase}Reload.mp3"; //https://freesound.org/people/nioczkus/sounds/396331/
        public static readonly string AudioSniperRifle = $"{AudioBase}SniperRifle.mp3"; //https://freesound.org/people/SuperPhat/sounds/514228/
        public static readonly Dictionary<string, double> AudioVolume = new()
        {
            { AudioAutofire, .6 },
            { AudioBow, 1 },
            { AudioDeepGunshot, .8 },
            { AudioExplosion, 1 },
            { AudioGunshot, .5 },
            { AudioMalfunction, .7 },
            { AudioMelee, .8 },
            { AudioReload, .9 },
            { AudioSniperRifle, 1 },
        };

        // Wound States
        public const string WoundStateUnharmed = "Unharmed";
        public const string WoundStateLightlyWounded = "Lightly Wounded";
        public const string WoundStateSeriouslyWounded = "Seriously Wounded";
        public const string WoundStateMortallyWounded = "Mortally Wounded";
        public const string WoundStateDead = "Dead";

        public const string ProgramStateRezzed = "Rezzed";
        public const string ProgramStateDerezzed = "Derezzed";

        public const string DefenseStateOperational = "Operational";
        public const string DefenseStateDestroyed = "Destroyed";

        // Standard Actions
        public const string ActionBrawl = "Brawl";
        public const string ActionChoke = "Choke";
        public const string ActionDeathSave = "Death Save";
        public const string ActionEvade = "Evade";
        public const string ActionGrab = "Grab";
        public const string ActionInitiative = "Initiative";
        public const string ActionThrowGrapple = "Throw (Grapple)";
        public const string ActionThrowObject = "Throw (Object)";

        // Net Actions
        public const string NetActionInterface = "Interface";
        public const string NetActionJackIn = "Jack In";
        public const string NetActionJackOut = "Jack Out";
        public const string NetActionActivateProgram = "Activate Program";
        public const string NetActionScanner = "Scanner";
        public const string NetActionBackdoor = "Backdoor";
        public const string NetActionCloak = "Cloak";
        public const string NetActionControl = "Control";
        public const string NetActionEyeDee = "Eye-Dee";
        public const string NetActionPathfinder = "Pathfinder";
        public const string NetActionSlide = "Slide";
        public const string NetActionVirus = "Virus";
        public const string NetActionZap = "Zap";

        // Languages - pg45
        public const string LanguageStreetslang = "Streetslang";

        // Local Expert Locations
        public const string LocalExpertYourHome = "Your Home";
        public const string LocalExpertBadlands = "Badlands";

        // Science Subcategories
        public const string ScienceChemistry = "Chemistry";

        // Stats
        // Black ICE / Programs
        public const string NetPerception = "PER";
        public const string NetSpeed = "SPD";
        public const string NetAttack = "ATK";
        public const string NetDefense = "DEF";
        public const string NetHitPoints = "REZ";
        // Mental Group
        public const string StatIntelligence = "Intelligence";
        public const string StatWillpower = "Willpower";
        public const string StatCool = "Cool";
        public const string StatEmpathy = "Empathy";
        // Combat Group
        public const string StatTechnique = "Technique";
        public const string StatReflexes = "Reflexes";
        // Fortune Group
        public const string StatLuck = "Luck";
        // Physical Group
        public const string StatBody = "Body";
        public const string StatDexterity = "Dexterity";
        public const string StatMovement = "Movement";
        // Abbreviations
        public const string AbbrIntelligence = "INT";
        public const string AbbrWillpower = "WILL";
        public const string AbbrCool = "COOL";
        public const string AbbrEmpathy = "EMP";
        public const string AbbrTechnique = "TECH";
        public const string AbbrReflexes = "REF";
        public const string AbbrLuck = "LUCK";
        public const string AbbrBody = "BODY";
        public const string AbbrDexterity = "DEX";
        public const string AbbrMovement = "MOVE";

        // SkillCategories
        public const string SkillCategoryAwareness = "Awareness";
        public const string SkillCategoryBody = "Body";
        public const string SkillCategoryControl = "Control";
        public const string SkillCategoryEducation = "Education";
        public const string SkillCategoryFighting = "Fighting";
        public const string SkillCategoryPerformance = "Performance";
        public const string SkillCategoryRangedWeapon = "Ranged Weapon";
        public const string SkillCategorySocial = "Social";
        public const string SkillCategoryTechnique = "Technique";
        // Skills
        public const string SkillInterface = "Interface"; // Netrunners and Demons
        public const string SkillCombatNumber = "Combat Number"; // Demons
        public const string SkillSurgery = "Surgery"; // Trauma Team / Medtech
        public const string SkillMedicalTech = "Medical Tech"; // Trauma Team / Medtech
        // Awareness Skills
        public const string SkillConcentration = "Concentration";
        public const string SkillConcealRevealObject = "Conceal / Reveal Object";
        public const string SkillLipReading = "Lip Reading";
        public const string SkillPerception = "Perception";
        public const string SkillTracking = "Tracking";
        // Body Skills
        public const string SkillAthletics = "Athletics";
        public const string SkillContortionist = "Contortionist";
        public const string SkillDance = "Dance";
        public const string SkillEndurance = "Endurance";
        public const string SkillResistTortureDrugs = "Resist Torture / Drugs";
        public const string SkillStealth = "Stealth";
        // Control Skills
        public const string SkillDriveLandVehicle = "Drive Land Vehicle";
        public const string SkillPilotAirVehicle = "Pilot Air Vehicle";
        public const string SkillPilotSeaVehicle = "Pilot Sea Vehicle";
        public const string SkillRiding = "Riding";
        // Education Skills
        public const string SkillAccounting = "Accounting";
        public const string SkillAnimalHandling = "Animal Handling";
        public const string SkillBureaucracy = "Bureaucracy";
        public const string SkillBusiness = "Business";
        public const string SkillComposition = "Composition";
        public const string SkillCriminology = "Criminology";
        public const string SkillCryptography = "Cryptography";
        public const string SkillDeduction = "Deduction";
        public const string SkillEducation = "Education";
        public const string SkillGamble = "Gamble";
        public const string SkillLanguage = "Language";
        public const string SkillLibrarySearch = "Library Search";
        public const string SkillLocalExpert = "Local Expert";
        public const string SkillScience = "Science";
        public const string SkillTactics = "Tactics";
        public const string SkillWildernessSurvival = "Wilderness Survival";
        // Fighting Skills
        public const string SkillBrawling = "Brawling";
        public const string SkillEvasion = "Evasion";
        public const string SkillMartialArts = "Martial Arts";
        public const string SkillMeleeWeapon = "Melee Weapon";
        // Performance Skills
        public const string SkillActing = "Acting";
        public const string SkillPlayInstrument = "Play Instrument";
        // Ranged Weapon Skills
        public const string SkillArchery = "Archery";
        public const string SkillAutofire = "Autofire";
        public const string SkillHandgun = "Handgun";
        public const string SkillHeavyWeapons = "Heavy Weapons";
        public const string SkillShoulderArms = "Shoulder Arms";
        // Social Skills
        public const string SkillBribery = "Bribery";
        public const string SkillConversation = "Conversation";
        public const string SkillHumanPerception = "Human Perception";
        public const string SkillInterrogation = "Interrogation";
        public const string SkillPersuasion = "Persuasion";
        public const string SkillPersonalGrooming = "Personal Grooming";
        public const string SkillStreetwise = "Streetwise";
        public const string SkillTrading = "Trading";
        public const string SkillWardrobeStyle = "Wardrobe & Style";
        // Technique Skills
        public const string SkillAirVehicleTech = "Air Vehicle Tech";
        public const string SkillBasicTech = "Basic Tech";
        public const string SkillCybertech = "Cybertech";
        public const string SkillDemolitions = "Demolitions";
        public const string SkillElectronicsSecurityTech = "Electronics/Security Tech";
        public const string SkillFirstAid = "First Aid";
        public const string SkillForgery = "Forgery";
        public const string SkillLandVehicleTech = "Land Vehicle Tech";
        public const string SkillPaintDrawSculpt = "Paint/Draw/Sculpt";
        public const string SkillParamedic = "Paramedic";
        public const string SkillPhotographyFilm = "Photography/Film";
        public const string SkillPickLock = "Pick Lock";
        public const string SkillPickPocket = "Pick Pocket";
        public const string SkillSeaVehicleTech = "Sea Vehicle Tech";
        public const string SkillWeaponstech = "Weaponstech";

        public static List<string> SkillsToSkipForCombatants = new()
        {
            SkillInterface, SkillCombatNumber,
            SkillConcentration, SkillLipReading, SkillTracking,
            SkillDance,
            SkillRiding,
            SkillActing,
            SkillAccounting, SkillAnimalHandling, SkillBureaucracy, SkillBusiness, SkillComposition, SkillCriminology,
            SkillCryptography, SkillDeduction, SkillEducation, SkillLibrarySearch, SkillWildernessSurvival, SkillLanguage, SkillLocalExpert,
            SkillArchery, SkillAutofire, SkillHandgun, SkillHeavyWeapons, SkillShoulderArms,
            SkillBribery, SkillConversation, SkillHumanPerception, SkillPersonalGrooming, SkillStreetwise, SkillWardrobeStyle,
            SkillCybertech, SkillForgery, SkillPaintDrawSculpt, SkillPhotographyFilm,
        };

        // Stat Reference Table
        public static readonly Dictionary<string, string> StatAbbreviations = new()
        {
            { StatIntelligence, AbbrIntelligence },
            { StatWillpower, AbbrWillpower },
            { StatCool, AbbrCool },
            { StatEmpathy, AbbrEmpathy },
            { StatTechnique, AbbrTechnique },
            { StatReflexes, AbbrReflexes },
            { StatLuck, AbbrLuck },
            { StatBody, AbbrBody },
            { StatDexterity, AbbrDexterity },
            { StatMovement, AbbrMovement }
        };

        // Skill Reference Table
        public static readonly List<SkillLinkReference> SkillLinks = new()
        {
            // Awareness Skills
            new(SkillCategoryAwareness, SkillConcentration, StatWillpower),
            new(SkillCategoryAwareness, SkillConcealRevealObject, StatIntelligence),
            new(SkillCategoryAwareness, SkillLipReading, StatIntelligence),
            new(SkillCategoryAwareness, SkillPerception, StatIntelligence),
            new(SkillCategoryAwareness, SkillTracking, StatIntelligence),
            // Body Skills
            new(SkillCategoryBody, SkillAthletics, StatDexterity),
            new(SkillCategoryBody, SkillContortionist, StatDexterity),
            new(SkillCategoryBody, SkillDance, StatDexterity),
            new(SkillCategoryBody, SkillEndurance, StatWillpower),
            new(SkillCategoryBody, SkillResistTortureDrugs, StatWillpower),
            new(SkillCategoryBody, SkillStealth, StatDexterity),
            // Control Skills
            new(SkillCategoryControl, SkillDriveLandVehicle, StatReflexes),
            new(SkillCategoryControl, SkillPilotAirVehicle, StatReflexes, 2),
            new(SkillCategoryControl, SkillPilotSeaVehicle, StatReflexes),
            new(SkillCategoryControl, SkillRiding, StatReflexes),
            // Education Skills
            new(SkillCategoryEducation, SkillAccounting, StatIntelligence),
            new(SkillCategoryEducation, SkillAnimalHandling, StatIntelligence),
            new(SkillCategoryEducation, SkillBureaucracy, StatIntelligence),
            new(SkillCategoryEducation, SkillBusiness, StatIntelligence),
            new(SkillCategoryEducation, SkillComposition, StatIntelligence),
            new(SkillCategoryEducation, SkillCriminology, StatIntelligence),
            new(SkillCategoryEducation, SkillCryptography, StatIntelligence),
            new(SkillCategoryEducation, SkillDeduction, StatIntelligence),
            new(SkillCategoryEducation, SkillEducation, StatIntelligence),
            new(SkillCategoryEducation, SkillGamble, StatIntelligence),
            new(SkillCategoryEducation, SkillLanguage, StatIntelligence),
            new(SkillCategoryEducation, SkillLibrarySearch, StatIntelligence),
            new(SkillCategoryEducation, SkillLocalExpert, StatIntelligence),
            new(SkillCategoryEducation, SkillScience, StatIntelligence),
            new(SkillCategoryEducation, SkillTactics, StatIntelligence),
            new(SkillCategoryEducation, SkillWildernessSurvival, StatIntelligence),
            // Fighting Skills
            new(SkillCategoryFighting, SkillBrawling, StatDexterity),
            new(SkillCategoryFighting, SkillEvasion, StatDexterity),
            new(SkillCategoryFighting, SkillMartialArts, StatDexterity, 2),
            new(SkillCategoryFighting, SkillMeleeWeapon, StatDexterity),
            // Performance Skills
            new(SkillCategoryPerformance, SkillActing, StatCool),
            new(SkillCategoryPerformance, SkillPlayInstrument, StatDexterity),
            // Ranged Weapon Skills
            new(SkillCategoryRangedWeapon, SkillArchery, StatReflexes),
            new(SkillCategoryRangedWeapon, SkillAutofire, StatReflexes, 2),
            new(SkillCategoryRangedWeapon, SkillHandgun, StatReflexes),
            new(SkillCategoryRangedWeapon, SkillHeavyWeapons, StatReflexes, 2),
            new(SkillCategoryRangedWeapon, SkillShoulderArms, StatReflexes),
            // Social Skills
            new(SkillCategorySocial, SkillBribery, StatCool),
            new(SkillCategorySocial, SkillConversation, StatEmpathy),
            new(SkillCategorySocial, SkillHumanPerception, StatEmpathy),
            new(SkillCategorySocial, SkillInterrogation, StatCool),
            new(SkillCategorySocial, SkillPersuasion, StatCool),
            new(SkillCategorySocial, SkillPersonalGrooming, StatCool),
            new(SkillCategorySocial, SkillStreetwise, StatCool),
            new(SkillCategorySocial, SkillTrading, StatCool),
            new(SkillCategorySocial, SkillWardrobeStyle, StatCool),
            // Technique Skills
            new(SkillCategoryTechnique, SkillAirVehicleTech, StatTechnique),
            new(SkillCategoryTechnique, SkillBasicTech, StatTechnique),
            new(SkillCategoryTechnique, SkillCybertech, StatTechnique),
            new(SkillCategoryTechnique, SkillDemolitions, StatTechnique, 2),
            new(SkillCategoryTechnique, SkillElectronicsSecurityTech, StatTechnique, 2),
            new(SkillCategoryTechnique, SkillFirstAid, StatTechnique),
            new(SkillCategoryTechnique, SkillForgery, StatTechnique),
            new(SkillCategoryTechnique, SkillLandVehicleTech, StatTechnique),
            new(SkillCategoryTechnique, SkillPaintDrawSculpt, StatTechnique),
            new(SkillCategoryTechnique, SkillParamedic, StatTechnique, 2),
            new(SkillCategoryTechnique, SkillPhotographyFilm, StatTechnique),
            new(SkillCategoryTechnique, SkillPickLock, StatTechnique),
            new(SkillCategoryTechnique, SkillPickPocket, StatTechnique),
            new(SkillCategoryTechnique, SkillSeaVehicleTech, StatTechnique),
            new(SkillCategoryTechnique, SkillWeaponstech, StatTechnique),

        };

        // Armor Types
        public const string ArmorTypeNone = "None";
        public const string ArmorTypeLeather = "Leather";
        public const string ArmorTypeKevlar = "Kevlar";
        public const string ArmorTypeLightArmorjack = "Light Armorjack";
        public const string ArmorTypeBodyweightSuit = "Bodyweight Suit";
        public const string ArmorTypeMediumArmorjack = "Medium Armorjack";
        public const string ArmorTypeHeavyArmorjack = "Heavy Armorjack";
        public const string ArmorTypeFlak = "Flak";
        public const string ArmorTypeMetalgear = "Metalgear";
        public const string ArmorTypeBulletproofShield = "Bulletproof Shield";
        public const string ArmorTypeSubdermal = "Subdermal";

        // Shield Types
        public const string ShieldTypeNone = "None";
        public const string ShieldTypeBulletproofShield = "Bulletproof Shield";
        public const string ShieldTypeCorpse = "Corpse";
        public const string ShieldTypeHumanShield = "Human Shield";

        public static readonly List<Armor> ArmorTable = new()
        {
            new(ArmorTypeNone, 0, 0),
            new(ArmorTypeLeather, 4, 0),
            new(ArmorTypeKevlar, 7, 0),
            new(ArmorTypeLightArmorjack, 11, 0),
            new(ArmorTypeBodyweightSuit, 11, 0),
            new(ArmorTypeMediumArmorjack, 12, 2),
            new(ArmorTypeHeavyArmorjack, 13, 2),
            new(ArmorTypeFlak, 15, 4),
            new(ArmorTypeMetalgear, 18, 4),
            new(ArmorTypeSubdermal, 11, 0)
        };

        // Corporation Names pg267

        #region WEAPONS
        // Weapon Categories - pg340
        public static readonly string WeaponTypeLightMelee = "Light Melee Weapon";
        public static readonly string WeaponTypeMediumMelee = "Medium Melee Weapon";
        public static readonly string WeaponTypeHeavyMelee = "Heavy Melee Weapon";
        public static readonly string WeaponTypeVeryHeavyMelee = "Very Heavy Melee Weapon";
        public static readonly string WeaponTypeMediumPistol = "Medium Pistol";
        public static readonly string WeaponTypeHeavyPistol = "Heavy Pistol";
        public static readonly string WeaponTypeVeryHeavyPistol = "Very Heavy Pistol";
        public static readonly string WeaponTypeSmg = "SMG";
        public static readonly string WeaponTypeHeavySmg = "Heavy SMG";
        public static readonly string WeaponTypeShotgun = "Shotgun";
        public static readonly string WeaponTypeAssaultRifle = "Assault Rifle";
        public static readonly string WeaponTypeSniperRifle = "Sniper Rifle";
        public static readonly string WeaponTypeBowsAndCrossbows = "Bows & Crossbows";
        public static readonly string WeaponTypeGrenadeLauncher = "Grenade Launcher";
        public static readonly string WeaponTypeRocketLauncher = "Rocket Launcher";
        public static readonly string WeaponTypeDartgun = "Dartgun";
        public static readonly string WeaponTypeFlamethrower = "Flamethrower";
        public static readonly string WeaponTypePopupGrenadeLauncher = "Popup Grenade Launcher";

        public static Dictionary<string, string> WeaponSounds = new()
        {
            { WeaponTypeLightMelee, AudioMelee },
            { WeaponTypeMediumMelee, AudioMelee },
            { WeaponTypeHeavyMelee, AudioMelee },
            { WeaponTypeVeryHeavyMelee, AudioMelee },
            { WeaponTypeMediumPistol, AudioGunshot },
            { WeaponTypeHeavyPistol, AudioGunshot },
            { WeaponTypeVeryHeavyPistol, AudioDeepGunshot },
            { WeaponTypeSmg, AudioGunshot },
            { WeaponTypeHeavySmg, AudioGunshot },
            { WeaponTypeShotgun, AudioDeepGunshot },
            { WeaponTypeAssaultRifle, AudioGunshot },
            { WeaponTypeSniperRifle, AudioSniperRifle },
            { WeaponTypeGrenadeLauncher, AudioExplosion },
            { WeaponTypeRocketLauncher, AudioExplosion },
            { WeaponTypePopupGrenadeLauncher, AudioExplosion },
            { WeaponTypeBowsAndCrossbows, AudioBow },
            { WeaponTypeFlamethrower, AudioDeepGunshot },
            { WeaponTypeDartgun, AudioBow },
        };

        // Ammunition Types
        public const string AmmoTypeNone = "None";
        public const string AmmoTypeMediumPistol = "Medium Pistol";
        public const string AmmoTypeHeavyPistol = "Heavy Pistol";
        public const string AmmoTypeVeryHeavyPistol = "Very Heavy Pistol";
        public const string AmmoTypeShell = "Shell";
        public const string AmmoTypeSlug = "Slug";
        public const string AmmoTypeRifle = "Rifle";
        public const string AmmoTypeArrow = "Arrow";
        public const string AmmoTypeGrenade = "Grenade";
        public const string AmmoTypeRocket = "Rocket";
        public const string AmmoTypeDart = "Dart";

        // Ammunition Variants
        public const string AmmoVarBasic = "Basic";
        public const string AmmoVarArmorPiercing = "Armor-Piercing";
        public const string AmmoVarBiotoxin = "Biotoxin";
        public const string AmmoVarEMP = "EMP";
        public const string AmmoVarExpansive = "Expansive";
        public const string AmmoVarFlashbang = "Flashbang";
        public const string AmmoVarIncendiary = "Incendiary";
        public const string AmmoVarPoison = "Poison";
        public const string AmmoVarRubber = "Rubber";
        public const string AmmoVarSleep = "Sleep";
        public const string AmmoVarSmart = "Smart";
        public const string AmmoVarSmoke = "Smoke";
        public const string AmmoVarTeargas = "Teargas";

        // Weapon Quality Tier
        public static readonly string WeaponQualityPoor = "Poor";
        public static readonly string WeaponQualityStandard = "Standard";
        public static readonly string WeaponQualityExcellent = "Excellent";

        public static readonly List<RangedWeaponClip> ClipChart = new()
        {
            new(WeaponTypeMediumPistol, 12, 18, 36),
            new(WeaponTypeHeavyPistol, 8, 14, 28),
            new(WeaponTypeVeryHeavyPistol, 8, 14, 28),
            new(WeaponTypeSmg, 30, 40, 50),
            new(WeaponTypeHeavySmg, 40, 50, 60),
            new(WeaponTypeShotgun, 4, 8, 16),
            new(WeaponTypeFlamethrower, 4, 8, 16),
            new(WeaponTypeAssaultRifle, 25, 35, 45),
            new(WeaponTypeSniperRifle, 4, 8, 12),
            new(WeaponTypeGrenadeLauncher, 2, 4, 6),
            new(WeaponTypePopupGrenadeLauncher, 1, 1, 1),
            new(WeaponTypeRocketLauncher, 1, 2, 3)
        };
        public static readonly List<RangedWeaponAmmoCompatibility> RangedWeaponAmmoCompatibilities = new()
        {
            new(WeaponTypeMediumPistol, AmmoTypeMediumPistol),
            new(WeaponTypeHeavyPistol, AmmoTypeHeavyPistol),
            new(WeaponTypeVeryHeavyPistol, AmmoTypeVeryHeavyPistol),
            new(WeaponTypeSmg, AmmoTypeMediumPistol),
            new(WeaponTypeHeavySmg, AmmoTypeHeavyPistol),
            new(WeaponTypeShotgun, AmmoTypeSlug, AmmoTypeShell),
            new(WeaponTypeAssaultRifle, AmmoTypeRifle),
            new(WeaponTypeSniperRifle, AmmoTypeRifle),
            new(WeaponTypeBowsAndCrossbows, AmmoTypeArrow),
            new(WeaponTypeGrenadeLauncher, AmmoTypeGrenade),
            new(WeaponTypeRocketLauncher, AmmoTypeRocket),
            new(WeaponTypePopupGrenadeLauncher, AmmoTypeGrenade),
            new(WeaponTypeDartgun, AmmoTypeDart),
            new(WeaponTypeFlamethrower, AmmoTypeShell)
        };

        public static readonly List<Weapon> WeaponRepository = new()
        {
            new(WeaponTypeLightMelee, SkillMeleeWeapon, 1, 1, AmmoTypeNone, 2, true),
            new(WeaponTypeMediumMelee, SkillMeleeWeapon, 2, 1, AmmoTypeNone, 2, true),
            new(WeaponTypeHeavyMelee, SkillMeleeWeapon, 3, 2, AmmoTypeNone, 2, true),
            new(WeaponTypeVeryHeavyMelee, SkillMeleeWeapon, 4, 2, AmmoTypeNone, 1, true),
            new(WeaponTypeMediumPistol, SkillHandgun, 2, 1, AmmoTypeMediumPistol, 2, true),
            new(WeaponTypeHeavyPistol, SkillHandgun, 3, 1, AmmoTypeHeavyPistol, 2, true),
            new(WeaponTypeVeryHeavyPistol, SkillHandgun, 4, 1, AmmoTypeVeryHeavyPistol, 1, false),
            new(WeaponTypeSmg, SkillHandgun, 2, 1, AmmoTypeMediumPistol, 1, true),
            new(WeaponTypeHeavySmg, SkillHandgun, 3, 1, AmmoTypeHeavyPistol, 1, false),
            new(WeaponTypeShotgun, SkillShoulderArms, 5, 2, AmmoTypeSlug, 1, false),
            new(WeaponTypeAssaultRifle, SkillShoulderArms, 5, 2, AmmoTypeRifle, 1, false),
            new(WeaponTypeSniperRifle, SkillShoulderArms, 5, 2, AmmoTypeRifle, 1, false),
            new(WeaponTypeBowsAndCrossbows, SkillArchery, 4, 2, AmmoTypeArrow, 1, false),
            new(WeaponTypeGrenadeLauncher, SkillHeavyWeapons, 6, 2, AmmoTypeGrenade, 1, false),
            new(WeaponTypePopupGrenadeLauncher, SkillHeavyWeapons, 6, 1, AmmoTypeGrenade, 1, true),
            new(WeaponTypeRocketLauncher, SkillHeavyWeapons, 8, 2, AmmoTypeRocket, 1, false),
            new(WeaponTypeDartgun, SkillHandgun, 2, 1, AmmoTypeDart, 1, true),
            new(WeaponTypeFlamethrower, SkillHeavyWeapons, 1, 2, AmmoTypeShell, 1, false)
        };
        public static readonly Dictionary<string, int> AutofireTable = new()
        {
            { WeaponTypeSmg, 3 },
            { WeaponTypeHeavySmg, 3 },
            { WeaponTypeAssaultRifle, 4 }
        };
        #endregion

        #region GEAR
        public const string GearAgent = "Agent";
        public const string GearAirhypo = "Airhypo";
        public const string GearAntiSmogBreathingMask = "Anti-Smog Breathing Mask";
        public const string GearAudioRecorder = "Audio Recorder";
        public const string GearAutoLevelDampeningEarProtectors = "Auto Level Dampening Ear Protectors";
        public const string GearBinoculars = "Binoculars";
        public const string GearBraindanceViewer = "Braindance Viewer";
        public const string GearBugDetector = "Bug Detector";
        public const string GearCarryall = "Carryall";
        public const string GearChemicalAnalyzer = "Chemical Analyzer";
        public const string GearComputer = "Computer";
        public const string GearCryopump = "Cryopump";
        public const string GearCryotank = "Cryotank";
        public const string GearCyberdeckExcellent = "Cyberdeck (Excellent Quality)";
        public const string GearCyberdeckPoor = "Cyberdeck (Poor Quality)";
        public const string GearCyberdeckStandard = "Cyberdeck (Standard Quality)";
        public const string GearDisposableCellPhone = "Disposable Cell Phone";
        public const string GearDrumSynthesizer = "Drum Synthesizer";
        public const string GearDuctTape = "Duct Tape";
        public const string GearElectricGuitar = "Electric Guitar";
        public const string GearFlashlight = "Flashlight";
        public const string GearFoodStick = "Food Stick";
        public const string GearGlowPaint = "Glow Paint";
        public const string GearGlowStick = "Glow Stick";
        public const string GearGrappleGun = "Grapple Gun";
        public const string GearHandcuffs = "Handcuffs";
        public const string GearHomingTracer = "Homing Tracer";
        public const string GearInflatableBed = "Inflatable Bed & Sleep-bag";
        public const string GearKibblePack = "Kibble Pack";
        public const string GearLinearFrameBeta = "Linear Frame Beta";
        public const string GearLinearFrameSigma = "Linear Frame Sigma";
        public const string GearLockPickingSet = "Lock Picking Set";
        public const string GearMedscanner = "Medscanner";
        public const string GearMedtechBag = "Medtech Bag";
        public const string GearMemoryChips = "Memory Chips";
        public const string GearMRE = "MRE";
        public const string GearPersonalCarePak = "Personal CarePak";
        public const string GearPocketAmplifier = "Pocket Amplifier";
        public const string GearRadarDetector = "Radar Detector";
        public const string GearRadioCommunicator = "Radio Communicator";
        public const string GearRadioScannerMusicPlayer = "Radio Scanner / Music Player";
        public const string GearRoadFlare = "Road Flare";
        public const string GearRope = "Rope (60m)";
        public const string GearScramblerDescrambler = "Scrambler / Descrambler";
        public const string GearSmartGlasses = "Smart Glasses";
        public const string GearTechBag = "Tech Bag";
        public const string GearTechscanner = "Techscanner";
        public const string GearTechtool = "Techtool";
        public const string GearTentAndCampingEquipment = "Tent & Camping Equipment";
        public const string GearVialOfBiotoxin = "Vial of Biotoxin";
        public const string GearVialOfPoison = "Vial of Poison";
        public const string GearVideoCamera = "Video Camera";
        public const string GearVirtualityGoggles = "Virtuality Goggles";
        // pg351+ for full gear descriptions and restrictions
        public static readonly Dictionary<string, string> MasterGearList = new()
        {
            { GearAgent, "Self-adaptive-AI powered smartphone." },
            { GearAirhypo, "Drug distribution platform." },
            { GearAntiSmogBreathingMask, "User is immune to the effects of dangers that must be inhaled to affect the user." },
            { GearAudioRecorder, "Device records up to 24 hours of audio to a Memory Chip." },
            { GearAutoLevelDampeningEarProtectors, "When worn, user is immune to deafness." },
            { GearBinoculars, "You look through them." },
            { GearBraindanceViewer, "Allows the user to experience braindance content." },
            { GearBugDetector, "Device beeps when within 2m/yds of a listening device." },
            { GearCarryall, "Heavy ripstop nylon bags of varying sizes." },
            { GearChemicalAnalyzer, "Can test substances as an Action to find their precise chemical composition." },
            { GearComputer, "Laptop or desktop computer." },
            { GearCryopump, "A Cryopump is a briefcase-sized tool containing a body bag hooked up to a powerful pump." },
            { GearCryotank, "A Cryotank is a human-sized container which can hold a fully grown adult." },
            { GearCyberdeckExcellent, "A high-end modular platform for Netrunning." },
            { GearCyberdeckPoor, "A cheap modular platform for Netrunning." },
            { GearCyberdeckStandard, "Modular platform for Netrunning." },
            { GearDisposableCellPhone, "A good choice people who don't want to be tracked." },
            { GearDrumSynthesizer, "Can simulate almost any kind of drum. Requires amplification." },
            { GearDuctTape, "Sticky tape, comes in various colors, including glow-in-the-dark." },
            { GearElectricGuitar, "Rock on!" },
            { GearFlashlight, "100m/yd beam." },
            { GearFoodStick, "One meal." },
            { GearGlowPaint, "Glow in the dark paint in a spray can." },
            { GearGlowStick, "Illuminate a 4m/yd area for up to 10 hours." },
            { GearGrappleGun, "Can fire a rocket propelled grapple that will attach securely to thick cover up to 30m/yds away." },
            { GearHandcuffs, "Can be broken if BODY > 10." },
            { GearHomingTracer, "Device can follow a linked tracer up to 1-mile away." },
            { GearInflatableBed, "Self-inflating air mattress with a thin sleeping bag." },
            { GearKibblePack, "Single meal." },
            { GearLinearFrameBeta, "Powered exoskeleton, user increases their BODY to 14 while plugged into the frame." },
            { GearLinearFrameSigma, "Powered exoskeleton, user increases their BODY to 12 while plugged into the frame." },
            { GearLockPickingSet, "Tools for cracking mechanical locks." },
            { GearMedscanner, "+2 to their First Aid and Paramedic Skills." },
            { GearMedtechBag, "Medical toolkit." },
            { GearMemoryChips, "Store information in all forms." },
            { GearMRE, "Self-heating plastic and foil meal bag." },
            { GearPersonalCarePak, "Assorted sundries." },
            { GearPocketAmplifier, "Rechargeable amplifier." },
            { GearRadarDetector, "Beeps if an active radar beam is present within 100m/yds." },
            { GearRadioCommunicator, "Earpiece, 1-mile range." },
            { GearRadioScannerMusicPlayer, "Music player, can also scan radio bands within a mile." },
            { GearRoadFlare, "Lights an area of 100m/yards for 1 hour." },
            { GearRope, "Holds up to 800lbs." },
            { GearScramblerDescrambler, "Allows user to scramble or descramble communications." },
            { GearSmartGlasses, "Contains two option slots for Cybereye options." },
            { GearTechBag, "Small bag of tools for fixing electronics and machines. Includes a Techtool." },
            { GearTechscanner, "+2 to Basic Tech, Cybertech, Land Vehicle Tech, Sea Vehicle Tech, Air Vehicle Tech, Electronics/Security Tech, and Weaponstech Skills." },
            { GearTechtool, "All-in-one multi-tool." },
            { GearTentAndCampingEquipment, "Small one-person tube tent." },
            { GearVialOfBiotoxin, "Apply to Light Melee as an Action, DV15 Resist Torture/Drugs Check on hit, 3d6 damage directly to their HP." },
            { GearVialOfPoison, "Apply to Light Melee as an Action, DV13 Resist Torture/Drugs Check on hit, 2d6 damage directly to their HP." },
            { GearVideoCamera, "Can record up to 12 hours of video and audio to Memory Chip." },
            { GearVirtualityGoggles, "Headset that projects cyberspace imagery for Netrunners." },
        };
        #endregion

        #region CYBERWARE
        // Fashionware
        public const string CyberwareBiomonitor = "Biomonitor";
        public const string CyberwareChemskin = "Chemskin";
        public const string CyberwareEmpThreading = "EMP Threading";
        public const string CyberwareLightTattoo = "Light Tattoo";
        public const string CyberwareShiftTacts = "Shift Tacts";
        public const string CyberwareSkinwatch = "Skinwatch";
        public const string CyberwareTechhair = "Techhair";

        // Neuralware
        public const string CyberwareNeuralLink = "Neural Link";
        public const string CyberwareBraindanceRecorder = "Braindance Recorder";
        public const string CyberwareChipwareSocket = "Chipware Socket";
        public const string CyberwareInterfacePlugs = "Interface Plugs";
        public const string CyberwareKerenzikov = "Kerenzikov";
        public const string CyberwareSandevistan = "Sandevistan";
        public const string CyberwareChemicalAnalyzer = "Chemical Analyzer";
        public const string CyberwareMemoryChip = "Memory Chip";
        public const string CyberwareOlfactoryBoost = "Olfactory Boost";
        public const string CyberwarePainEditor = "Pain Editor";
        public const string CyberwareSkillChip = "Skill Chip";
        public const string CyberwareTactileBoost = "Tactile Boost";

        // Cyberoptics
        public const string CyberwareCybereye = "Cybereye";
        public const string CyberwareAntiDazzle = "Anti-Dazzle";
        public const string CyberwareChyron = "Chyron";
        public const string CyberwareColorShift = "Color Shift";
        public const string CyberwareDartgun = "Dartgun";
        public const string CyberwareImageEnhance = "Image Enhance";
        public const string CyberwareLowLightInfraredUv = "Low Light / Infrared / UV";
        public const string CyberwareMicroOptics = "MicroOptics";
        public const string CyberwareMicroVideo = "MicroVideo";
        public const string CyberwareRadiationDetector = "Radiation Detector";
        public const string CyberwareTargetingScope = "Targeting Scope";
        public const string CyberwareTeleOptics = "TeleOptics";
        public const string CyberwareVirtuality = "Virtuality";

        // Cyberaudio
        public const string CyberwareCyberaudioSuite = "Cyberaudio Suite";
        public const string CyberwareAmplifiedHearing = "Amplified Hearing";
        public const string CyberwareAudioRecorder = "Audio Recorder";
        public const string CyberwareBugDetector = "Bug Detector";
        public const string CyberwareHomingtracer = "Homing Tracer";
        public const string CyberwareInternalAgent = "Internal Agent";
        public const string CyberwareLevelDamper = "Level Damper";
        public const string CyberwareRadioCommunicator = "Radio Communicator";
        public const string CyberwareRadioScannerMusicPlayer = "Radio Scanner / Music Player";
        public const string CyberwareRadarDetector = "Radar Detector";
        public const string CyberwareScramblerDescrambler = "Scrambler / Descrambler";
        public const string CyberwareVoiceStressAnalyzer = "Voice Stress Analyzer";

        // Internal Cyberware
        public const string CyberwareAudioVox = "AudioVox";
        public const string CyberwareContraceptiveImplant = "Contraceptive Implant";
        public const string CyberwareEnhancedAntibodies = "Enhanced Antibodies";
        public const string CyberwareCybersnake = "Cybersnake";
        public const string CyberwareGills = "Gills";
        public const string CyberwareGraftedMuscleBoneLace = "Grafted Muscle and Bone Lace";
        public const string CyberwareIndependentAirSupply = "Independent Air Supply";
        public const string CyberwareMidnightLady = "Midnight Lady Sexual Implant ";
        public const string CyberwareMrStudd = "Mr. Studd Sexual Implant";
        public const string CyberwareNasalFilters = "Nasal Filters";
        public const string CyberwareRadarSonarImplant = "Radar / Sonar Implant";
        public const string CyberwareToxinBinders = "Toxin Binders";
        public const string CyberwareVampyres = "Vampyres";

        // External Cyberware
        public const string CyberwareHiddenHolster = "Hidden Holster";
        public const string CyberwareSkinWeave = "Skin Weave";
        public const string CyberwareSubdermalArmor = "Subdermal Armor";
        public const string CyberwareSubdermalPocket = "Subdermal Pocket";

        // Cyberlimbs - Arms
        public const string CyberwareCyberarm = "Cyberarm";
        public const string CyberwareStandardHand = "Standard Hand";
        public const string CyberwareBigKnucks = "Big Knucks";
        public const string CyberwareCyberdeck = "Cyberdeck";
        public const string CyberwareGrappleHand = "GrappleHand";
        public const string CyberwareMedscanner = "Medscanner";
        public const string CyberwarePopupGrenadeLauncher = "Popup Grenade Launcher";
        public const string CyberwarePopupMeleeWeapon = "Popup Melee Weapon";
        public const string CyberwarePopupShield = "Popup Shield";
        public const string CyberwarePopupRangedWeapon = "Popup Ranged Weapon";
        public const string CyberwareQuickChangeMount = "Quick Change Mount";
        public const string CyberwareRippers = "Rippers";
        public const string CyberwareScratchers = "Scratchers";
        public const string CyberwareShoulderCam = "Shoulder Cam";
        public const string CyberwareSliceAndDice = "Slice 'N Dice";
        public const string CyberwareSubdermalGrip = "Subdermal Grip";
        public const string CyberwareTechscanner = "Techscanner";
        public const string CyberwareToolHand = "Tool Hand";
        public const string CyberwareWolvers = "Wolvers";

        // Cyberlimbs - Legs
        public const string CyberwareCyberleg = "Cyberleg";
        public const string CyberwareStandardFoot = "Standard Foot";
        public const string CyberwareGripFoot = "Grip Foot";
        public const string CyberwareJumpBooster = "Jump Booster";
        public const string CyberwareSkateFoot = "Skate Foot";
        public const string CyberwareTalonFoot = "Talon Foot";
        public const string CyberwareWebFoot = "Web Foot";

        // Cyberlimbs - Misc
        public const string CyberwareHardenedShielding = "Hardened Shielding";
        public const string CyberwarePlasticCovering = "Plastic Covering";
        public const string CyberwareRealskinnCovering = "Realskinn Covering";
        public const string CyberwareSuperchromeCovering = "Superchrome Covering";

        // Borgware
        public const string CyberwareArtificialShoulderMount = "Artificial Shoulder Mount";
        public const string CyberwareImplantedLinearFrameBeta = "Implanted Linear Frame Beta";
        public const string CyberwareImplantedLinearFrameSigma = "Implanted Linear Frame Sigma";
        public const string CyberwareMultiOpticMount = "MultiOptic Mount";
        public const string CyberwareSensorArray = "Sensor Array";

        // pg 111+ for additional details and restrictions for cyberware
        // TODO - stat and skill calculations for various Cyberware
        public static readonly Dictionary<string, string> MasterCyberwareList = new()
        {
            // Fashionware - pg111
            { CyberwareBiomonitor, "Shows a readout of vitals." },
            { CyberwareChemskin, "+2 to Personal Grooming." },
            { CyberwareEmpThreading, "Silver circuit patterns across the body." },
            { CyberwareLightTattoo, "+2 to Wardrobe and Style." },
            { CyberwareShiftTacts, "Color-changing lenses." },
            { CyberwareSkinwatch, "LED watch." },
            { CyberwareTechhair, "+2 to Personal Grooming." },

            // Neuralware - pg112
            { CyberwareNeuralLink, "Required to use Neuralware and Subdermal Grip." },
            { CyberwareBraindanceRecorder, "Records user's experiences." },
            { CyberwareChipwareSocket, "Required to use Chipware." },
            { CyberwareInterfacePlugs, "Plugs that allow connection to machines." },
            { CyberwareKerenzikov, "+2 to Initiative." },
            { CyberwareSandevistan, "When activated as an Action adds +3 to Initiative for one minute. Has 1 hour cool down period." },
            { CyberwareChemicalAnalyzer, "Tests substance for precise chemical composition." },
            { CyberwareMemoryChip, "Store or access data." },
            { CyberwareOlfactoryBoost, "User can use Tracking Skill to track via scent." },
            { CyberwarePainEditor, "User ignores penalties due to being Seriously Wounded." },
            { CyberwareSkillChip, "User has specific Skill at Level 3 unless Skill is already 3+." },
            { CyberwareTactileBoost, "User can detect motion within 20m/yd." },

            // Cyberoptics - pg112-113
            { CyberwareCybereye, "Artificial Eye." },
            { CyberwareAntiDazzle, "User immune to effects caused by flashes of light." },
            { CyberwareChyron, "Projects subscreen into user's field of vision." },
            { CyberwareColorShift, "Unlimited color and pattern changes for the eye." },
            { CyberwareDartgun, "Single shot Dartgun Exotic Weapon concealed in eye." },
            { CyberwareImageEnhance, "Adds +2 to Perception, Lip Reading, and Conceal/Reveal Object." },
            { CyberwareLowLightInfraredUv, "User can ignore penalties due to darkness, smoke, fog, etc." },
            { CyberwareMicroOptics, "Provides user with 400x magnification." },
            { CyberwareMicroVideo, "Camera in eye. Records audio and video to Memory Chip or linked Agent." },
            { CyberwareRadiationDetector, "Radiation readings within 100m/yds displayed in form of blue glow." },
            { CyberwareTargetingScope, "Adds +1 to Check when making Aimed Shot." },
            { CyberwareTeleOptics, "Can see detail up to 800m/yd away. +1 to Aimed Shots against target 51m/yds or farther away." },
            { CyberwareVirtuality, "Projects cyberspace imagery over user's view of the world." },

            // Cyberaudio - pg113
            { CyberwareCyberaudioSuite, string.Empty },
            { CyberwareAmplifiedHearing, "+2 to Perception for Checks involving hearing." },
            { CyberwareAudioRecorder, "Records audio to Memory Chip or linked Agent." },
            { CyberwareBugDetector, "Beeps when within 2m/yds of a listening device." },
            { CyberwareHomingtracer, "Can follow a linked tracer up to 1 mile away." },
            { CyberwareInternalAgent, "Fully functional Agent installed internally." },
            { CyberwareLevelDamper, "User immune to effects caused by loud noises." },
            { CyberwareRadioCommunicator, "User can communicate via radio." },
            { CyberwareRadioScannerMusicPlayer, "Can play music or tune into radio broadcasts." },
            { CyberwareRadarDetector, "Beeps if active radar beam is within 100m/yd." },
            { CyberwareScramblerDescrambler, "Allows user to scramble outgoing communications and descramble incoming communications." },
            { CyberwareVoiceStressAnalyzer, "+2 to Human Perception and Interrogation Checks." },

            // Internal Cyberware - pg114
            { CyberwareAudioVox, "Voice synthesizer. Adds +2 to Acting and Play Instrument when singing." },
            { CyberwareContraceptiveImplant, "Prevents undesired pregnancy." },
            { CyberwareEnhancedAntibodies, "After stabilization, user heals BODY x 2 for each day spent resting." },
            { CyberwareCybersnake, "Esophagus mounted Very Heavy Melee Weapon." },
            { CyberwareGills, "User can breathe underwater." },
            { CyberwareGraftedMuscleBoneLace, "Increases BODY by 2." },
            { CyberwareIndependentAirSupply, "Provides 30 minutes of oxygen." },
            { CyberwareMidnightLady, "Super-V" },
            { CyberwareMrStudd, "Super-D" },
            { CyberwareNasalFilters, "User immune to effects of toxic gases." },
            { CyberwareRadarSonarImplant, "Scans terrain within 50m/yds." },
            { CyberwareToxinBinders, "Adds +2 to Resist Torture/Drugs." },
            { CyberwareVampyres, "Excellent Quality Light Melee Weapon implanted in mouth." },

            // External Cyberware - pg114
            { CyberwareHiddenHolster, "Can store weapon capable of concealment inside body." },
            { CyberwareSkinWeave, "User's body and head armored at SP7. Recovers 1 SP per day of rest." },
            { CyberwareSubdermalArmor, "User's body and head armored at SP11. Recovers 1 SP per day of rest." },
            { CyberwareSubdermalPocket, "Storage space just under the skin." },

            // Cyberlimbs - Arms - pg115
            { CyberwareCyberarm, "Replacement arm. Comes installed with Standard Hand." },
            { CyberwareStandardHand, "Standard cybernetic hand. Can be installed in a meat arm." },
            { CyberwareBigKnucks, "Armored knuckles." },
            { CyberwareCyberdeck, "Cyberdeck installed in Cyberarm." },
            { CyberwareGrappleHand, "Fires hand, along with a grapple line up to 30m/yds." },
            { CyberwareMedscanner, "+2 to First Aid and Paramedic." },
            { CyberwarePopupGrenadeLauncher, "A single shot Grenade Launcher installed in a Cyberarm." },
            { CyberwarePopupMeleeWeapon, "Any Light, Medium, or Heavy Melee Weapon installed in a Cyberarm." },
            { CyberwarePopupShield, "A Bulletproof Shield installed in the Cyberarm." },
            { CyberwarePopupRangedWeapon, "Any One Handed Ranged Weapon installed in a Cyberarm." },
            { CyberwareQuickChangeMount, "Allows user to remove or install a Cyberarm as an Action." },
            { CyberwareRippers, "Carbo-glass claws. Medium Melee Weapon." },
            { CyberwareScratchers, "Carbo-glass fingernails. Light Melee Weapon." },
            { CyberwareShoulderCam, "Video camera mounted in shoulder." },
            { CyberwareSliceAndDice, "Monofilament whip implanted in the thumb. Medium Melee Weapon." },
            { CyberwareSubdermalGrip, "Allows user to use Smartgun without Interface Plug." },
            { CyberwareTechscanner, "+2 to multiple TECH-based Skills." },
            { CyberwareToolHand, "Fingers contain screwdriver, wrench, small drill, and other tools." },
            { CyberwareWolvers, "Long claws extended from the knuckles. Heavy Melee Weapon." },

            // Cyberlimbs - Legs - pg116
            { CyberwareCyberleg, "Replacement leg. Comes installed with Standard Foot." },
            { CyberwareStandardFoot, "Standard cybernetic foot." },
            { CyberwareGripFoot, "Negates movement penalty when climbing." },
            { CyberwareJumpBooster, "Negates movement penalty when jumping." },
            { CyberwareSkateFoot, "Increases movement by 6m/yds when using Run Action." },
            { CyberwareTalonFoot, "Blade mounted in foot. Light Melee Weapon." },
            { CyberwareWebFoot, "Negates movement penalty when swimming." },

            // Cyberlimbs - Misc - pg116
            { CyberwareHardenedShielding, "Cyberlimb and installed options cannot be rendered inoperable by EMP pulses or Non-Black ICE Program effects." },
            { CyberwarePlasticCovering, "Plastic coating for Cyberlimb." },
            { CyberwareRealskinnCovering, "Artificial skin coating for Cyberlimb." },
            { CyberwareSuperchromeCovering, "Shiny metallic coating for Cyberlimb. +2 to Wardrobe and Style." },

            // Borgware - pg116
            { CyberwareArtificialShoulderMount, "User can mount 2 Cyberarms under first set of arms." },
            { CyberwareImplantedLinearFrameBeta, "Enhanced skeleton and support structure. Increases BODY to 14." },
            { CyberwareImplantedLinearFrameSigma, "Enhanced skeleton and support structure. Increases BODY to 12." },
            { CyberwareMultiOpticMount, "User can mount up to 5 additional Cybereyes." },
            { CyberwareSensorArray, "User can install up to 5 additional Cyberaudio Options." },

        };

        #endregion

        #region PROGRAMS
        public const string ProgramClassBooster = "Booster";
        public const string ProgramClassDefender = "Defender";
        public const string ProgramClassAntiPersonnelAttacker = "Anti-Personnel Attacker";
        public const string ProgramClassAntiProgramAttacker = "Anti-Program Attacker";

        public const string ProgramEraser = "Eraser";
        public const string ProgramSeeYa = "See Ya";
        public const string ProgramSpeedyGonzalvez = "Speedy Gonzalvez";
        public const string ProgramWorm = "Worm";

        public const string ProgramArmor = "Armor";
        public const string ProgramFlak = "Flak";
        public const string ProgramShield = "Shield";

        public const string ProgramBanhammer = "Banhammer";
        public const string ProgramSword = "Sword";
        public const string ProgramDeckKrash = "DeckKRASH";
        public const string ProgramHellbolt = "Hellbolt";
        public const string ProgramNervescrub = "Nervescrub";
        public const string ProgramPoisonFlatline = "Poison Flatline";
        public const string ProgramSuperglue = "Superglue";
        public const string ProgramVrizzbolt = "Vrizzbolt";

        public const string BlackIceKiller = "Killer";

        public static readonly List<CyberdeckProgram> CyberdeckPrograms = new()
        {
            new(ProgramEraser, PortraitDefault, ProgramClassBooster, 0, 0, 7, "Increases all CLoak Checks you make by +2 as long as this Program remains Rezzed."),
            new(ProgramSeeYa, PortraitDefault, ProgramClassBooster, 0, 0, 7, "Increases all Pathfinder Checks you make by +2 as long as this Program remains Rezzed"),
            new(ProgramSpeedyGonzalvez, PortraitDefault, ProgramClassBooster, 0, 0, 7, "Increases you Speed by +2 as long as this Program remains rezzed"),
            new(ProgramWorm, PortraitDefault, ProgramClassBooster, 0, 0, 7, "Increases all Backdoor Checks you make by +2 as long as this Program remains Rezzed"),

            new(ProgramArmor, PortraitDefault, ProgramClassDefender, 0, 0, 7, "Lowers all brain damage you would receive by 4, as long as this Program remains Rezzed. Only 1 copy of this Program can be running at a time. Each copy of this Program can only be used once per Netrun."),
            new(ProgramFlak, PortraitDefault, ProgramClassDefender, 0, 0, 7, "Reduces the ATK of all Non-Black ICE Attacker Programs run against you to 0 as long as this Program remains Rezzed. Only 1 copy of this Program can be running at a time. Each copy of this Program can only be used once per Netrun."),
            new(ProgramShield, PortraitDefault, ProgramClassDefender, 0, 0, 7, "Stops the first successful Non-Black ICE Program Effect from dealing brain damage. After stopping this damage, the Shield Derezzes itself. Only 1 copy of this Program can be running at a time. Each copy of this Program can only be used once per Netrun."),

            new(ProgramBanhammer, PortraitDefault, ProgramClassAntiProgramAttacker, 1, 0, 0, "Does 3d6 REZ to a Non-Black ICE Program, or 2d6 REZ to a Black ICE Program."),
            new(ProgramSword, PortraitDefault, ProgramClassAntiProgramAttacker, 1, 0, 0, "Does 3d6 REZ to a Black ICE Program, or 2d6 REZ to a Non-Black ICE Program."),
            new(ProgramDeckKrash, PortraitDefault, ProgramClassAntiPersonnelAttacker, 0, 0, 0, "Enemy Netrunner is forcibly and unsafely Jacked Out of the Architecture, suffering the effect of all Rezzed enemy Black ICE they've encountered in the Architecture as they leave."),
            new(ProgramHellbolt, PortraitDefault, ProgramClassAntiPersonnelAttacker, 2, 0, 0, "Does 2d6 Damage direct to the enemy Netrunner's brain. Unless insulated, their Cyberdeck catches fire along with their clothing. Until they spend a Meat Action to put themselves out, they take 2 damage to their HP whenever they end their Turn. Multiple instances of this effect cannot stack."),
            new(ProgramNervescrub, PortraitDefault, ProgramClassAntiPersonnelAttacker, 0, 0, 0, "Enemy Netrunner's INT, REF, and DEX are each lowered by 1d6 for the next hour (minimum 1). The effects are largely psychosomatic and leave no permanent effects."),
            new(ProgramPoisonFlatline, PortraitDefault, ProgramClassAntiPersonnelAttacker, 0, 0, 0, "Destroys a single Non-Black ICE Program installed on the Netrunner target's Cyberdeck at random."),
            new(ProgramSuperglue, PortraitDefault, ProgramClassAntiPersonnelAttacker, 2, 0, 0, "Enemy Netrunner cannot progress deeper into the Architecture or Jack Out safely for 1d6 Rounds (enemy Netrunner can still perform an unsafe Jack Out, though). Each copy of this Program can only be used once per Netrun."),
            new(ProgramVrizzbolt, PortraitDefault, ProgramClassAntiPersonnelAttacker, 1, 0, 0, "Does 1d6 Damage direct to a Netrunner's brain and lowers the amount of total NET Actions the Netrunner can accomplish on their next Turn by 1 (minimum 2).")
        };
        #endregion

        #region Critical Injuries
        // Body Injuries
        public const string CriticalInjuryDismemberedArm = "Dismembered Arm";
        public const string CriticalInjuryDismemberedHand = "Dismembered Hand";
        public const string CriticalInjuryCollapsedLung = "Collapsed Lung";
        public const string CriticalInjuryBrokenRibs = "Broken Ribs";
        public const string CriticalInjuryBrokenArm = "Broken Arm";
        public const string CriticalInjuryForeignObject = "Foreign Object";
        public const string CriticalInjuryBrokenLeg = "Broken Leg";
        public const string CriticalInjuryTornMuscle = "Torn Muscle";
        public const string CriticalInjurySpinalInjury = "Spinal Injury";
        public const string CriticalInjuryCrushedFingers = "Crushed Fingers";
        public const string CriticalInjuryDismemberedLeg = "Dismembered Leg";

        // Head Injuries
        public const string CriticalInjuryLostEye = "Lost Eye";
        public const string CriticalInjuryBrainInjury = "Brain Injury";
        public const string CriticalInjuryDamagedEye = "Damaged Eye";
        public const string CriticalInjuryConcussion = "Concussion";
        public const string CriticalInjuryBrokenJaw = "Broken Jaw";
        public const string CriticalInjuryWhiplash = "Whiplash";
        public const string CriticalInjuryCrackedSkull = "Cracked Skull";
        public const string CriticalInjuryDamagedEar = "Damaged Ear";
        public const string CriticalInjuryCrushedWindpipe = "Crushed Windpipe";
        public const string CriticalInjuryLostEar = "Lost Ear";

        public static readonly List<CriticalInjury> CriticalInjuriesToBody = new()
        {
            new(CriticalInjuryDismemberedArm, "The Dismembered Arm is gone. You drop any items in that dismembered arm's hand immediately. Base Death Save Penalty is increased by 1."),
            new(CriticalInjuryDismemberedHand, "The Dismembered Hand is gone. You drop any items in the dismembered hand immediately. Base Death Save Penalty is increased by 1."),
            new(CriticalInjuryCollapsedLung, "-2 to MOVE (minimum 1) Base Death Save Penalty is increased by 1."),
            new(CriticalInjuryBrokenRibs, "At the end of every Turn where you move further than 4m/yds on foot, you re-suffer this Critical Injury's Bonus Damage directly to your Hit Points."),
            new(CriticalInjuryBrokenArm, "The Broken Arm cannot be used. You drop any items in that arm's hand immediately."),
            new(CriticalInjuryForeignObject, "At the end of every Turn where you move further than 4m/yds on foot, you re-suffer this Critical Injury's Bonus Damage directly to your Hit Points."),
            new(CriticalInjuryBrokenLeg, "-4 to MOVE (minimum 1)"),
            new(CriticalInjuryTornMuscle, "-2 to Melee Attacks"),
            new(CriticalInjurySpinalInjury, "Next Turn, you cannot take an Action, but you can still take a Move Action. Base Death Save Penalty is increased by 1."),
            new(CriticalInjuryCrushedFingers, "-4 to all Actions involving that hand"),
            new(CriticalInjuryDismemberedLeg, "The Dismembered Leg is gone. -6 to MOVE (minimum 1) You cannot dodge attacks. Base Death Save Penalty is increased by 1.")
        };

        public static readonly List<CriticalInjury> CriticalInjuriesToHead = new()
        {
            new(CriticalInjuryLostEye, "The Lost Eye is gone. -4 to Ranged Attacks & Perception Checks involving vision. Base Death Save Penalty is increased by 1."),
            new(CriticalInjuryBrainInjury, "-2 to all Actions. Base Death Save Penalty is increased by 1."),
            new(CriticalInjuryDamagedEye, "-2 to Ranged Attacks & Perception Checks involving vision."),
            new(CriticalInjuryConcussion, "-2 to all Actions"),
            new(CriticalInjuryBrokenJaw, "-4 to all Actions involving speech"),
            new(CriticalInjuryForeignObject, "At the end of every Turn where you move further than 4m/yds on foot, you re-suffer this Critical Injury's Bonus Damage directly to your Hit Points."),
            new(CriticalInjuryWhiplash, "Base Death Save Penalty is increased by 1."),
            new(CriticalInjuryCrackedSkull, "Aimed Shots to your head multiply the damage that gets through your SP by 3 instead of 2. Base Death Save Penalty is increased by 1."),
            new(CriticalInjuryDamagedEar, "Whenever you move further than 4m/yds on foot in a Turn, you cannot take a Move Action on your next Turn. Additionally you take a -2 to Perception Checks involving hearing."),
            new(CriticalInjuryCrushedWindpipe, "You cannot speak. Base Death Save Penalty is increased by 1."),
            new(CriticalInjuryLostEar, "The Lost Ear is gone. Whenever you move further than 4m/yds on foot in a Turn, you cannot take a Move Action on your next Turn. Additionally you take a -4 to Perception Checks involving hearing. Base Death Save Penalty is increased by 1.")
        };

        public static List<CriticalInjury> AllCriticalInjuries;

        public static readonly List<string> CriticalInjuriesThatIncreaseDeathSavePenalty = new()
        {
            CriticalInjuryDismemberedArm, CriticalInjuryDismemberedHand, CriticalInjuryCollapsedLung, CriticalInjurySpinalInjury, CriticalInjuryDismemberedLeg,
            CriticalInjuryLostEye, CriticalInjuryBrainInjury, CriticalInjuryWhiplash, CriticalInjuryCrackedSkull, CriticalInjuryCrushedWindpipe, CriticalInjuryLostEar
        };

        public static readonly Dictionary<string, int> CriticalInjuryMovePenalties = new()
        {
            { CriticalInjuryCollapsedLung, 2 },
            { CriticalInjuryBrokenLeg, 4 },
            { CriticalInjuryDismemberedLeg, 6 }
        };

        #endregion

        public static List<Combatant> Combatants = new();
        public static List<Combatant> BlackIcePrograms = new();
        public static List<Combatant> Demons = new();
        public static List<Combatant> ActiveDefenses = new();
        public static List<Combatant> EmplacedDefenses = new();

        // Public Methods
        public static void PopulateData()
        {
            PopulateCriticalInjuries();
            PopulateCombatants();
            PopulateBlackIcePrograms();
            PopulateDemons();
            PopulateActiveDefenses();
            PopulateEmplacedDefenses();
        }



        // Private Methods
        private static void PopulateCombatants()
        {
            // pg 155 - Exec Company Aides
            // pg 158 - Lawman Backup
            // pg 224 - Trauma Team
            // pg 412 - Mooks and Grunts
            // pg 417 - Other Encounters

            // CIVILIANS
            Combatant scavenger = new("Scavenger", ComTypeStandard, ComClassCivilian, PortraitDefault, ArmorTypeNone);
            scavenger.SetStats(3, 5, 4, 2, 2, 3, 0, 3, 5, 3);
            scavenger.SetSkillLevels(2, SkillStreetwise);
            scavenger.SetSkillLevels(3, SkillPerception, SkillResistTortureDrugs, SkillStealth);
            scavenger.SetSkillLevels(4, SkillConcealRevealObject, SkillHandgun);
            scavenger.SetSkillLevels(5, SkillBrawling, SkillMeleeWeapon);
            scavenger.AddWeapon(WeaponTypeHeavyPistol, WeaponQualityPoor);
            scavenger.AddWeapon(WeaponTypeLightMelee, WeaponQualityStandard, "Knife");
            scavenger.AddAmmo(AmmoTypeHeavyPistol, 8);
            scavenger.InitializeNewCombatant();
            Combatants.Add(scavenger);

            // GANGERS
            Combatant thug = new("Thug", ComTypeStandard, ComClassLightGanger, PortraitDefault, ArmorTypeLeather);
            thug.SetStats(2, 6, 5, 2, 4, 2, 0, 4, 4, 3);
            thug.SetSkillLevels(2, SkillInterrogation, SkillStealth);
            thug.SetSkillLevels(3, SkillEndurance);
            thug.SetSkillLevels(4, SkillBrawling, SkillPerception, SkillResistTortureDrugs);
            thug.SetSkillLevels(5, SkillEvasion, SkillHandgun, SkillMeleeWeapon);
            thug.AddWeapon(WeaponTypeMediumMelee, WeaponQualityStandard, "Baseball Bat");
            thug.InitializeNewCombatant();
            Combatants.Add(thug);

            Combatant thugPistol = thug.DeepClone();
            thugPistol.Variant = "(Pistol)";
            thugPistol.AddWeapon(WeaponTypeMediumPistol, WeaponQualityPoor);
            thugPistol.AddBasicAmmoForAllWeapons(2);
            thugPistol.InitializeNewCombatant();
            Combatants.Add(thugPistol);

            // CORPOS
            List<string> CorpoBasicGear = new() { GearAgent };
            // LIGHT CORPOS
            Combatant guard = new("Guard", ComTypeStandard, ComClassLightCorpo, PortraitDefault, ArmorTypeKevlar);
            guard.SetStats(3, 6, 5, 2, 4, 3, 0, 4, 4, 3);
            guard.AddWeapon(WeaponTypeMediumPistol);
            guard.AddWeapon(WeaponTypeMediumMelee, WeaponQualityStandard, "Baton");
            guard.AddAmmo(AmmoTypeMediumPistol, 24);
            guard.AddGearSet(GearDisposableCellPhone);
            guard.InitializeNewCombatant();
            Combatants.Add(guard);

            Combatant guardSmg = guard.DeepClone();
            guardSmg.Variant = "(SMG)";
            guardSmg.SetSkillLevels(5, SkillAutofire);
            guardSmg.ResetWeaponsAndAmmo();
            guardSmg.AddWeapon(WeaponTypeSmg);
            guardSmg.AddWeapon(WeaponTypeMediumMelee, WeaponQualityStandard, "Baton");
            guardSmg.AddAmmo(AmmoTypeMediumPistol, 60);
            guardSmg.InitializeNewCombatant();
            Combatants.Add(guardSmg);

            Combatant bodyguard = new("Bodyguard", ComTypeStandard, ComClassLightCorpo, PortraitDefault, ArmorTypeLightArmorjack);
            bodyguard.SetStats(4, 8, 5, 3, 7, 8, 0, 6, 6, 3);
            bodyguard.SetSkillLevels(2, SkillConcentration, SkillConversation, SkillEducation, SkillFirstAid, SkillHumanPerception, SkillPersuasion, SkillStealth);
            bodyguard.SetSkillLevels(4, SkillAthletics, SkillEvasion, SkillInterrogation, SkillPerception, SkillResistTortureDrugs, SkillTactics);
            bodyguard.SetSkillLevels(6, SkillHandgun, SkillBrawling);
            bodyguard.AddWeapons(WeaponTypeVeryHeavyPistol);
            bodyguard.AddBasicAmmoForAllWeapons(5);
            bodyguard.AddGearSet(CorpoBasicGear);
            bodyguard.AddCyberwareSet(CyberwareEnhancedAntibodies, CyberwareSubdermalArmor, CyberwareCyberaudioSuite, CyberwareInternalAgent, CyberwareHomingtracer);
            bodyguard.InitializeNewCombatant();
            Combatants.Add(bodyguard);

            Combatant covertOperative = new("Covert Operative", ComTypeStandard, ComClassLightCorpo, PortraitDefault, ArmorTypeLightArmorjack);
            covertOperative.SetStats(6, 7, 5, 5, 7, 6, 0, 3, 7, 4);
            covertOperative.SetSkillLevels(2, SkillAthletics, SkillBrawling, SkillConcentration, SkillConversation, SkillEducation, SkillFirstAid, SkillPerception, SkillPersuasion);
            covertOperative.SetSkillLevels(4, SkillBribery, SkillBureaucracy, SkillBusiness, SkillEvasion, SkillHumanPerception, SkillPickLock, SkillStreetwise, SkillTrading, SkillWardrobeStyle);
            covertOperative.SetSkillLevels(6, SkillHandgun, SkillStealth);
            covertOperative.AddWeapons(WeaponTypeVeryHeavyPistol);
            covertOperative.AddBasicAmmoForAllWeapons(5);
            covertOperative.AddGearSet(CorpoBasicGear);
            covertOperative.AddCyberwareSet(CyberwareCybereye, CyberwareCybereye, CyberwareLowLightInfraredUv, CyberwareColorShift, CyberwareGrappleHand, CyberwarePopupRangedWeapon, CyberwareRealskinnCovering);
            covertOperative.InitializeNewCombatant();
            Combatants.Add(covertOperative);

            Combatant driver = new("Driver", ComTypeStandard, ComClassLightCorpo, PortraitDefault, ArmorTypeLightArmorjack);
            driver.SetStats(6, 8, 8, 4, 7, 4, 0, 5, 6, 2);
            driver.SetSkillLevels(2, SkillAthletics, SkillConcentration, SkillEducation, SkillFirstAid, SkillHumanPerception, SkillPerception, SkillPersuasion);
            driver.SetSkillLevels(4, SkillBrawling, SkillEndurance, SkillEvasion, SkillLandVehicleTech, SkillPilotAirVehicle, SkillPilotSeaVehicle, SkillSeaVehicleTech, SkillStealth, SkillTracking);
            driver.SetSkillLevels(6, SkillDriveLandVehicle, SkillHandgun);
            driver.AddWeapons(WeaponTypeVeryHeavyPistol);
            driver.AddBasicAmmoForAllWeapons(5);
            driver.AddGearSet(CorpoBasicGear);
            driver.AddCyberwareSet(CyberwareRadarSonarImplant, CyberwareCyberaudioSuite, CyberwareInternalAgent, CyberwareHomingtracer, CyberwareRadarDetector);
            driver.InitializeNewCombatant();
            Combatants.Add(driver);
            
            Combatant corpNet = new("Netrunner", ComTypeStandard, ComClassLightCorpo, PortraitDefault, ArmorTypeLightArmorjack);
            corpNet.SetStats(5, 6, 8, 8, 6, 6, 0, 4, 4, 3);
            corpNet.SetSkillLevels(2, SkillInterface, SkillAthletics, SkillBrawling, SkillConcentration, SkillConversation, SkillEvasion, SkillFirstAid, SkillHumanPerception, SkillPerception, SkillPersuasion);
            corpNet.SetSkillLevels(4, SkillBasicTech, SkillCryptography, SkillCybertech, SkillEducation, SkillElectronicsSecurityTech, SkillForgery, SkillLibrarySearch, SkillHandgun, SkillStealth);
            corpNet.AddWeapons(WeaponTypeVeryHeavyPistol);
            corpNet.AddBasicAmmoForAllWeapons(5);
            corpNet.AddGearSet(CorpoBasicGear);
            corpNet.AddCyberwareSet(CyberwareNeuralLink, CyberwareChipwareSocket, CyberwarePainEditor, CyberwareInterfacePlugs, CyberwareCybereye, CyberwareCybereye, CyberwareVirtuality);
            corpNet.SetNetActions();
            corpNet.AddCyberdeckPrograms(ProgramSword, BlackIceKiller, ProgramWorm, ProgramArmor);
            corpNet.InitializeNewCombatant();
            Combatants.Add(corpNet);

            Combatant corpTech = new("Technician", ComTypeStandard, ComClassLightCorpo, PortraitDefault, ArmorTypeLightArmorjack);
            corpTech.SetStats(8, 6, 5, 8, 4, 3, 0, 3, 7, 6);
            corpTech.SetSkillLevels(2, SkillAthletics, SkillBrawling, SkillConcentration, SkillConversation, SkillEvasion, SkillFirstAid, SkillHumanPerception, SkillPerception, SkillPersuasion, SkillStealth);
            corpTech.SetSkillLevels(4, SkillEducation, SkillHandgun, SkillWeaponstech);
            corpTech.SetSkillLevels(6, SkillBasicTech, SkillCybertech, SkillElectronicsSecurityTech);
            corpTech.AddWeapons(WeaponTypeVeryHeavyPistol);
            corpTech.AddBasicAmmoForAllWeapons(5);
            corpTech.AddGearSet(CorpoBasicGear);
            corpTech.AddCyberwareSet(CyberwareToolHand, CyberwareCyberaudioSuite, CyberwareInternalAgent, CyberwareBugDetector, CyberwareAudioRecorder);
            corpTech.InitializeNewCombatant();
            Combatants.Add(corpTech);

            // POLICE
            List<string> PoliceBasicGear = new() { GearAgent, GearCarryall, GearFlashlight, GearFoodStick, GearHandcuffs, GearRoadFlare };
            List<string> PoliceExtraGear = new() { GearRadioCommunicator, GearRadioScannerMusicPlayer, GearHandcuffs };
            // LIGHT POLICE
            Combatant security = new("Security", ComTypeStandard, ComClassLightPolice, PortraitDefault, ArmorTypeKevlar);
            security.SetStats(2, 4, 3, 3, 3, 2, 0, 4, 2, 3);
            security.AddWeapon(WeaponTypeHeavyPistol);
            security.AddBasicAmmoForAllWeapons(3);
            security.AddGearSet(PoliceBasicGear);
            security.InitializeNewCombatant();
            Combatants.Add(security);

            Combatant beatCop = new("Beat Cop", ComTypeStandard, ComClassLightPolice, PortraitDefault, ArmorTypeKevlar);
            beatCop.SetStats(2, 4, 3, 3, 3, 2, 0, 4, 4, 3);
            beatCop.AddWeapon(WeaponTypeHeavyPistol);
            beatCop.AddBasicAmmoForAllWeapons(3);
            beatCop.AddGearSet(PoliceBasicGear);
            beatCop.InitializeNewCombatant();
            Combatants.Add(beatCop);

            // MEDIUM POLICE
            Combatant deputy = new("Deputy", ComTypeStandard, ComClassMediumPolice, PortraitDefault, ArmorTypeHeavyArmorjack);
            deputy.SetStats(3, 8, 4, 3, 4, 5, 0, 4, 5, 4);
            deputy.SetSkillLevels(6, SkillHandgun, SkillShoulderArms, SkillAutofire, SkillEvasion);
            deputy.AddWeapons(WeaponTypeHeavyPistol, WeaponTypeAssaultRifle);
            deputy.AddBasicAmmoForAllWeapons(3);
            deputy.AddGearSet(PoliceBasicGear);
            deputy.AddGearSet(PoliceExtraGear);
            deputy.InitializeNewCombatant();
            Combatants.Add(deputy);

            Combatant marshall = new("Marshall", ComTypeStandard, ComClassMediumPolice, PortraitDefault, ArmorTypeFlak);
            marshall.SetStats(4, 8, 6, 5, 5, 10, 0, 6, 6, 5);
            marshall.SetSkillLevels(6, SkillEvasion);
            marshall.SetSkillLevels(8, SkillHandgun, SkillShoulderArms, SkillAutofire, SkillHeavyWeapons, SkillBrawling);
            marshall.AddWeapons(WeaponTypeVeryHeavyPistol, WeaponTypeAssaultRifle, WeaponTypeGrenadeLauncher);
            marshall.AddBasicAmmoForAllWeapons(3);
            marshall.AddGearSet(PoliceBasicGear);
            marshall.AddGearSet(PoliceExtraGear);
            marshall.InitializeNewCombatant();
            Combatants.Add(marshall);

            // HEAVY POLICE
            Combatant swat = new("SWAT", ComTypeStandard, ComClassHeavyPolice, PortraitDefault, ArmorTypeMetalgear);
            swat.SetStats(3, 8, 5, 4, 4, 6, 0, 4, 4, 4);
            swat.SetSkillLevels(7, SkillHandgun, SkillShoulderArms, SkillAutofire, SkillHeavyWeapons, SkillBrawling);
            swat.AddWeapons(WeaponTypeAssaultRifle, WeaponTypeRocketLauncher);
            swat.AddBasicAmmoForAllWeapons(3);
            swat.AddGearSet(PoliceBasicGear);
            swat.AddGearSet(PoliceExtraGear);
            swat.InitializeNewCombatant();
            Combatants.Add(swat);

            Combatant fed = new("Federal Agent", ComTypeStandard, ComClassHeavyPolice, PortraitDefault, ArmorTypeLightArmorjack);
            fed.SetStats(5, 8, 6, 5, 5, 5, 0, 6, 6, 4);
            fed.SetSkillLevels(6, SkillHandgun, SkillShoulderArms, SkillAutofire, SkillBrawling, SkillEvasion);
            fed.SetSkillLevels(4, SkillAccounting, SkillActing, SkillConcealRevealObject, SkillCriminology, SkillCryptography, SkillDeduction, SkillEducation);
            fed.SetSkillLevels(4, SkillForgery, SkillInterrogation, SkillParamedic, SkillPerception, SkillPersonalGrooming, SkillResistTortureDrugs, SkillStealth, SkillTracking);
            fed.AddWeapons(WeaponTypeVeryHeavyPistol, WeaponTypeAssaultRifle);
            fed.AddBasicAmmoForAllWeapons(3);
            fed.AddGearSet(PoliceBasicGear);
            fed.AddGearSet(PoliceExtraGear);
            fed.InitializeNewCombatant();
            Combatants.Add(fed);

        }
        private static void PopulateCriticalInjuries()
        {
            AllCriticalInjuries = new();
            AllCriticalInjuries.AddRange(CriticalInjuriesToBody);
            AllCriticalInjuries.AddRange(CriticalInjuriesToHead);
        }
        private static void PopulateBlackIcePrograms()
        {
            Combatant asp = new("Asp", BlackIce, BlackIce, PortraitAsp, ArmorTypeNone);
            asp.SetBlackIceStats(AntiPersonnelBlackIce, 4, 6, 2, 2, 15, "Destroys a single Program installed on the enemy Netrunner's Cyberdeck at random.");
            BlackIcePrograms.Add(asp);

            Combatant giant = new("Giant", BlackIce, BlackIce, PortraitGiant, ArmorTypeNone);
            giant.SetBlackIceStats(AntiPersonnelBlackIce, 2, 2, 8, 4, 25, "Does 3d6 damage direct to an enemy Netrunner's brain. The Netrunner is forcibly and unsafely Jacked Out of their current Netrun. They suffer the effect of all Rezzed enemy Black ICE they've encountered in the Architecture as they leave, not including the Giant.");
            BlackIcePrograms.Add(giant);

            Combatant hellhound = new("Hellhound", BlackIce, BlackIce, PortraitHellhound, ArmorTypeNone);
            hellhound.SetBlackIceStats(AntiPersonnelBlackIce, 6, 6, 6, 2, 20, "Does 2d6 damage direct to the Netrunner's brain. Unless insulated, their Cyberdeck catches fire along with their clothing. Until they spend a Meat Action to put themselves out, they take 2 damage to their HP whenever they end their Turn. Multiple instances of this effect cannot stack.");
            BlackIcePrograms.Add(hellhound);

            Combatant kraken = new("Kraken", BlackIce, BlackIce, PortraitKraken, ArmorTypeNone);
            kraken.SetBlackIceStats(AntiPersonnelBlackIce, 6, 2, 8, 4, 30, "Does 3d6 damage direct to an enemy Netrunner's brain. Until the end of the Netrunner's next Turn, the Netrunner cannot progress deeper into the Architecture or Jack Out safely (The Netrunner can still perform an unsafe Jack Out).");
            BlackIcePrograms.Add(kraken);

            Combatant liche = new("Liche", BlackIce, BlackIce, PortraitLiche, ArmorTypeNone);
            liche.SetBlackIceStats(AntiPersonnelBlackIce, 8, 2, 6, 2, 25, "Enemy Netrunner's INT, REF, and DEX are each lowered by 1d6 for the next hour (minimum 1). The effects are largely psychosomatic and leave no permanent effects.");
            BlackIcePrograms.Add(liche);

            Combatant raven = new("Raven", BlackIce, BlackIce, PortraitRaven, ArmorTypeNone);
            raven.SetBlackIceStats(AntiPersonnelBlackIce, 6, 4, 4, 2, 15, "Derezzes a single Defender Program the enemy Netrunner has Rezzed at random, then deals 1d6 damage direct to the Netrunner's brain.");
            BlackIcePrograms.Add(raven);

            Combatant scorpion = new("Scorpion", BlackIce, BlackIce, PortraitScorpion, ArmorTypeNone);
            scorpion.SetBlackIceStats(AntiPersonnelBlackIce, 2, 6, 2, 2, 15, "Enemy Netrunner's MOVE is lowered by 1d6 for the next hour (minimum 1). The effects are largely psychosomatic and leave no permanent effects.");
            BlackIcePrograms.Add(scorpion);

            Combatant skunk = new("Skunk", BlackIce, BlackIce, PortraitSkunk, ArmorTypeNone);
            skunk.SetBlackIceStats(AntiPersonnelBlackIce, 2, 4, 4, 2, 10, "Until this Program is Derezzed, an enemy Netrunner hit by this Effect makes all Slide Checks at a -2. Each Skunk Black ICE can only affect a single Netrunner at a time, but the effects of multiple Skunks can stack.");
            BlackIcePrograms.Add(skunk);

            Combatant wisp = new("Wisp", BlackIce, BlackIce, PortraitWisp, ArmorTypeNone);
            wisp.SetBlackIceStats(AntiPersonnelBlackIce, 4, 4, 4, 2, 15, "Does 1d6 damage direct to the enemy Netrunner's brain and lowers the amount of total NET Actions the Netrunner can accomplish on their next Turn by 1 (minimum 2).");
            BlackIcePrograms.Add(wisp);

            Combatant dragon = new("Dragon", BlackIce, BlackIce, PortraitDragon, ArmorTypeNone);
            dragon.SetBlackIceStats(AntiProgramBlackIce, 6, 4, 6, 6, 30, "Deals 6d6 damage to a Program. If this damage would be enough to Derezz the Program, it is instead Destroyed.");
            BlackIcePrograms.Add(dragon);

            Combatant killer = new("Killer", BlackIce, BlackIce, PortraitKiller, ArmorTypeNone);
            killer.SetBlackIceStats(AntiProgramBlackIce, 4, 8, 6, 2, 20, "Deals 4d6 damage to a Program. If this damage would be enough to Derezz the Program, it is instead Destroyed.");
            BlackIcePrograms.Add(killer);

            Combatant sabertooth = new("Sabertooth", BlackIce, BlackIce, PortraitSabertooth, ArmorTypeNone);
            sabertooth.SetBlackIceStats(AntiProgramBlackIce, 8, 6, 6, 2, 25, "Deals 6d6 damage to a Program. If this damage would be enough to Derezz the Program, it is instead Destroyed.");
            BlackIcePrograms.Add(sabertooth);

        }
        private static void PopulateDemons()
        {
            Combatant imp = new("Imp", Demon, Demon, PortraitImp, ArmorTypeNone);
            imp.SetDemonStats(15, 3, 2, 14);
            Demons.Add(imp);

            Combatant efreet = new("Efreet", Demon, Demon, PortraitEfreet, ArmorTypeNone);
            efreet.SetDemonStats(25, 3, 2, 14);
            Demons.Add(efreet);

            Combatant balron = new("Balron", Demon, Demon, PortraitBalron, ArmorTypeNone);
            balron.SetDemonStats(30, 7, 4, 14);
            Demons.Add(balron);

        }
        private static void PopulateActiveDefenses()
        {
            // TODO - Defense combatant portraits
            Combatant airSwarm = new("Air Swarm Drone Cloud", ActiveDefense, ActiveDefense, PortraitDefault, ArmorTypeNone);
            airSwarm.SetActiveDefenseStats(8, 15, 17);
            airSwarm.AddWeapon(WeaponTypeVeryHeavyMelee, WeaponQualityStandard);
            ActiveDefenses.Add(airSwarm);

            Combatant groundDrone = new("Ground Drone", ActiveDefense, ActiveDefense, PortraitDefault, ArmorTypeNone);
            groundDrone.SetActiveDefenseStats(4, 30, 21);
            groundDrone.AddWeapon(WeaponTypeVeryHeavyPistol, WeaponQualityStandard);
            groundDrone.AddWeapon(WeaponTypeSmg, WeaponQualityStandard);
            groundDrone.AddAmmo(AmmoTypeVeryHeavyPistol, 8, AmmoVarArmorPiercing);
            groundDrone.AddAmmo(AmmoTypeMediumPistol, 30);
            ActiveDefenses.Add(groundDrone);

            Combatant largeAirDrone = new("Large Air Drone", ActiveDefense, ActiveDefense, PortraitDefault, ArmorTypeNone);
            largeAirDrone.SetActiveDefenseStats(6, 20, 21);
            largeAirDrone.AddWeapon(WeaponTypeDartgun, WeaponQualityStandard);
            largeAirDrone.AddWeapon(WeaponTypeVeryHeavyPistol, WeaponQualityStandard);
            largeAirDrone.AddAmmo(AmmoTypeDart, 8);
            largeAirDrone.AddAmmo(AmmoTypeVeryHeavyPistol, 8, AmmoVarArmorPiercing);
            ActiveDefenses.Add(largeAirDrone);

            Combatant miniAirDrone = new("Mini Air Drone", ActiveDefense, ActiveDefense, PortraitDefault, ArmorTypeNone);
            miniAirDrone.SetActiveDefenseStats(6, 15, 17);
            miniAirDrone.AddWeapon(WeaponTypeDartgun, WeaponQualityStandard);
            miniAirDrone.AddWeapon(WeaponTypeVeryHeavyPistol, WeaponQualityStandard);
            miniAirDrone.AddAmmo(AmmoTypeDart, 8);
            miniAirDrone.AddAmmo(AmmoTypeVeryHeavyPistol, 8, AmmoVarArmorPiercing);
            ActiveDefenses.Add(miniAirDrone);

            Combatant spiderDrone = new("Spider Walking Drone", ActiveDefense, ActiveDefense, PortraitDefault, ArmorTypeNone);
            spiderDrone.SetActiveDefenseStats(4, 40, 21);
            spiderDrone.AddWeapon(WeaponTypeGrenadeLauncher, WeaponQualityStandard);
            spiderDrone.AddWeapon(WeaponTypeVeryHeavyMelee, WeaponQualityStandard);
            spiderDrone.AddWeapon(WeaponTypeHeavySmg, WeaponQualityStandard);
            spiderDrone.AddAmmo(AmmoTypeGrenade, 2, AmmoVarTeargas);
            spiderDrone.AddAmmo(AmmoTypeHeavyPistol, 40);

        }
        private static void PopulateEmplacedDefenses()
        {
            Combatant bloodSwarm = new("Automated Blood Swarm", EmplacedDefense, EmplacedDefense, PortraitDefault, ArmorTypeNone);
            bloodSwarm.SetEmplacedDefenseStats(0, 1, 21, "Automated weapon disperses a swarm of nanites into the room as a red fog. The nanites, when inhaled, attack their victim from within by binding the hemoglobin in their blood into clots. Anything that filters gas attacks blocks the Automated Blood Swarm.\nEveryone Meat within the Defended Area must succeed at a DV15 Resist Torture/ Drugs Check. Anyone who fails is dealt 3d6 damage directly to their HP. Their armor isn't ablated.");
            EmplacedDefenses.Add(bloodSwarm);

            Combatant melee = new("Automated Melee Weapon", EmplacedDefense, EmplacedDefense, PortraitDefault, ArmorTypeNone);
            melee.SetEmplacedDefenseStats(14, 25, 17);
            melee.AddWeapon(WeaponTypeVeryHeavyMelee, WeaponQualityStandard);
            EmplacedDefenses.Add(melee);

            Combatant turret = new("Turret", EmplacedDefense, EmplacedDefense, PortraitDefault, ArmorTypeNone);
            turret.SetEmplacedDefenseStats(14, 25, 17);

            Combatant turretAR = turret.DeepClone();
            turretAR.Variant = "(AR)";
            turretAR.AddWeapon(WeaponTypeAssaultRifle);
            turretAR.AddBasicAmmoForAllWeapons(1);
            EmplacedDefenses.Add(turretAR);

            Combatant turretSMG = turret.DeepClone();
            turretSMG.Variant = "(SMG)";
            turretSMG.AddWeapon(WeaponTypeHeavySmg);
            turretSMG.AddBasicAmmoForAllWeapons(1);
            EmplacedDefenses.Add(turretSMG);


        }


    }
}
