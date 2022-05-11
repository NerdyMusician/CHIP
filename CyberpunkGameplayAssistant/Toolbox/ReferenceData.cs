using CyberpunkGameplayAssistant.Models;
using CyberpunkGameplayAssistant.ViewModels;
using System;
using System.Collections.Generic;
using System.Windows;

namespace CyberpunkGameplayAssistant.Toolbox
{
    public static class ReferenceData
    {
        // Utility
        public const bool DebugMode = true;
        public static MainViewModel MainModelRef;
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

        // Combatant Types
        public const string Player = "Player";
        public const string NPC = "NPC";
        public const string BlackIce = "Black ICE";
        public const string Demon = "Demon";
        public const string ActiveDefense = "Active Defense";
        public const string EmplacedDefense = "Emplaced Defense";

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

        // Error Messages
        public const string ErrorNoDemonAvailableForActiveDefense = "No Demon available to run this Active Defense.";

        // Image Locations
        private const string ImageBase = "/Resources/Combatants/";
        public const string PortraitAssassin = $"{ImageBase}Assassin.png";
        public const string PortraitBodyguard = $"{ImageBase}Bodyguard.png";
        public const string PortraitBoosterganger = $"{ImageBase}Boosterganger.png";
        public const string PortraitCanineDrone = $"{ImageBase}Canine Drone.png";
        public const string PortraitCyberpsycho = $"{ImageBase}Cyberpsycho.png";
        public const string PortraitEdgerunner = $"{ImageBase}Edgerunner.png";
        public const string PortraitExecNetrunner = $"{ImageBase}Exec Netrunner.png";
        public const string PortraitExec = $"{ImageBase}Exec.png";
        public const string PortraitFixer = $"{ImageBase}Fixer.png";
        public const string PortraitMaxTacRiot = $"{ImageBase}MaxTac Riot.png";
        public const string PortraitMaxTac = $"{ImageBase}MaxTac.png";
        public const string PortraitMedia = $"{ImageBase}Media.png";
        public const string PortraitMonk = $"{ImageBase}Monk.png";
        public const string PortraitNeko = $"{ImageBase}Neko.png";
        public const string PortraitNetrunner = $"{ImageBase}Netrunner.png";
        public const string PortraitNomad = $"{ImageBase}Nomad.png";
        public const string PortraitOutrider = $"{ImageBase}Outrider.png";
        public const string PortraitPyro = $"{ImageBase}Pyro.png";
        public const string PortraitRacer = $"{ImageBase}Racer.png";
        public const string PortraitReclaimerChief = $"{ImageBase}Reclaimer Chief.png";
        public const string PortraitRoadGanger = $"{ImageBase}Road Ganger.png";
        public const string PortraitRoadWarrior = $"{ImageBase}Road Warrior.png";
        public const string PortraitRockergirl = $"{ImageBase}Rockergirl.png";
        public const string PortraitSecurityOfficer = $"{ImageBase}Security Officer.png";
        public const string PortraitSecurityOperative = $"{ImageBase}Security Operative.png";
        public const string PortraitSolo = $"{ImageBase}Solo.png";
        public const string PortraitTech = $"{ImageBase}Tech.png";
        public const string PortraitTraumaTeamDoctor = $"{ImageBase}TT Doc.png";
        public const string PortraitTraumaTeamMedic = $"{ImageBase}TT Medic.png";
        public const string PortraitTraumaTeamOfficer = $"{ImageBase}TT Officer.png";

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

        // Stat Categories
        public const string StatCategoryMental = "Mental";
        public const string StatCategoryCombat = "Combat";
        public const string StatCategoryFortune = "Fortune";
        public const string StatCategoryPhysical = "Physical";

        // Cultural Regions
        public const string CulturalRegionNorthAmerican = "North American";
        public const string CulturalRegionSouthCentralAmerican = "South/Central American";
        public const string CulturalRegionWesternEuropean = "Western European";
        public const string CulturalRegionEasternEuropean = "Eastern European";
        public const string CulturalRegionMiddleEasterNorthAfrican = "Middle Eastern/North African";
        public const string CulturalRegionSubSaharanAfrican = "Sub-Saharan African";
        public const string CulturalRegionSouthAsian = "South Asian";
        public const string CulturalRegionSouthEastAsian = "South East Asian";
        public const string CulturalRegionEastAsian = "East Asian";
        public const string CulturalRegionOceaniaPacificIslander = "Oceania/Pacific Islander";

        // Languages - pg45
        public const string LanguageArabic = "Arabic";
        public const string LanguageBengali = "Bengali";
        public const string LanguageBerber = "Berber";
        public const string LanguageBurmese = "Burmese";
        public const string LanguageCantoneseChinese = "Cantonese Chinese";
        public const string LanguageChinese = "Chinese";
        public const string LanguageCree = "Cree";
        public const string LanguageCreole = "Creole";
        public const string LanguageDari = "Dari";
        public const string LanguageEnglish = "English";
        public const string LanguageFarsi = "Farsi";
        public const string LanguageFilipino = "Filipino";
        public const string LanguageFinnish = "Finnish";
        public const string LanguageFrench = "French";
        public const string LanguageGerman = "German";
        public const string LanguageGuarani = "Guarani";
        public const string LanguageHausa = "Hausa";
        public const string LanguageHawaiian = "Hawaiian";
        public const string LanguageHebrew = "Hebrew";
        public const string LanguageHindi = "Hindi";
        public const string LanguageIndonesian = "Indonesian";
        public const string LanguageItalian = "Italian";
        public const string LanguageJapanese = "Japanese";
        public const string LanguageKhmer = "Khmer";
        public const string LanguageKorean = "Korean";
        public const string LanguageLingala = "Lingala";
        public const string LanguageMalayan = "Malayan";
        public const string LanguageMandarinChinese = "Mandarin Chinese";
        public const string LanguageMaori = "Maori";
        public const string LanguageMayan = "Mayan";
        public const string LanguageMongolian = "Mongolian";
        public const string LanguageNavajo = "Navajo";
        public const string LanguageNative = "Native";
        public const string LanguageNepali = "Nepali";
        public const string LanguageNorwegian = "Norwegian";
        public const string LanguageOromo = "Oromo";
        public const string LanguagePamaNyungan = "Pama-Nyungan";
        public const string LanguagePolish = "Polish";
        public const string LanguagePortuguese = "Portuguese";
        public const string LanguageQuechua = "Quechua";
        public const string LanguageRomanian = "Romanian";
        public const string LanguageRussian = "Russian";
        public const string LanguageSinhalese = "Sinhalese";
        public const string LanguageSpanish = "Spanish";
        public const string LanguageStreetslang = "Streetslang";
        public const string LanguageSwahili = "Swahili";
        public const string LanguageTahitian = "Tahitian";
        public const string LanguageTamil = "Tamil";
        public const string LanguageTurkish = "Turkish";
        public const string LanguageTwi = "Twi";
        public const string LanguageUkranian = "Ukranian";
        public const string LanguageUrdu = "Urdu";
        public const string LanguageVietnamese = "Vietnamese";
        public const string LanguageYoruba = "Yoruba";

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

        // Complete Package Calculated Skills - pg90
        public const int CompletePackageSkillPoints = 86;
        public const int CompletePackageSkillLevelLimit = 6;
        public static readonly List<Skill> CompletePackageRequiredSkills = new()
        {
            new(SkillAthletics),
            new(SkillBrawling),
            new(SkillConcentration),
            new(SkillConversation),
            new(SkillEducation),
            new(SkillEvasion),
            new(SkillFirstAid),
            new(SkillHumanPerception),
            new(SkillLanguage, LanguageStreetslang),
            new(SkillLocalExpert, LocalExpertYourHome),
            new(SkillPerception),
            new(SkillPersuasion),
            new(SkillStealth)
        };

        // Stat Reference Table
        public static readonly List<StatLinkReference> StatLinks = new()
        {
            new(StatCategoryMental, StatIntelligence, AbbrIntelligence),
            new(StatCategoryMental, StatWillpower, AbbrWillpower),
            new(StatCategoryMental, StatCool, AbbrCool),
            new(StatCategoryMental, StatEmpathy, AbbrEmpathy),
            new(StatCategoryCombat, StatTechnique, AbbrTechnique),
            new(StatCategoryCombat, StatReflexes, AbbrReflexes),
            new(StatCategoryFortune, StatLuck, AbbrLuck),
            new(StatCategoryPhysical, StatBody, AbbrBody),
            new(StatCategoryPhysical, StatDexterity, AbbrDexterity),
            new(StatCategoryPhysical, StatMovement, AbbrMovement),
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

        // ArmorTypes
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

        public static readonly List<Armor> ArmorTable = new()
        {
            new(ArmorTypeLeather, 4, 0),
            new(ArmorTypeKevlar, 7, 0),
            new(ArmorTypeLightArmorjack, 11, 0),
            new(ArmorTypeBodyweightSuit, 11, 0),
            new(ArmorTypeMediumArmorjack, 12, -2),
            new(ArmorTypeHeavyArmorjack, 13, -2),
            new(ArmorTypeFlak, 15, -4),
            new(ArmorTypeMetalgear, 18, -4),
            new(ArmorTypeSubdermal, 11, 0)
        };

        // Corporation Names
        public const string CorpoArasaka = "Arasaka";
        public const string CorpoChadranArms = "Chadran Arms";
        public const string CorpoDaiLung = "Dai Lung";
        public const string CorpoEagletech = "Eagletech";
        public const string CorpoFederatedArms = "Federated Arms";
        public const string CorpoGunMart = "GunMart";
        public const string CorpoMilitech = "Militech";
        public const string CorpoMustangArms = "Mustang Arms";
        public const string CorpoNomad = "Nomad";
        public const string CorpoNova = "Nova";
        public const string CorpoSternmeyer = "Sternmeyer";
        public const string CorpoTowaManufacturing = "Towa Manufacturing";
        public const string CorpoTsunamiArms = "Tsunami Arms";

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

        // Ammunition Types
        public static readonly string AmmoTypeNone = "None";
        public static readonly string AmmoTypeMediumPistol = "Medium Pistol";
        public static readonly string AmmoTypeHeavyPistol = "Heavy Pistol";
        public static readonly string AmmoTypeVeryHeavyPistol = "Very Heavy Pistol";
        public static readonly string AmmoTypeSlug = "Slug";
        public static readonly string AmmoTypeRifle = "Rifle";
        public static readonly string AmmoTypeArrow = "Arrow";
        public static readonly string AmmoTypeGrenade = "Grenade";
        public static readonly string AmmoTypeRocket = "Rocket";
        public static readonly string AmmoTypeDart = "Dart";
        public static readonly string AmmoTypeIncendiaryShell = "Incendiary Shotgun Shell";

        // Weapon Quality Tier
        public static readonly string WeaponQualityPoor = "Poor";
        public static readonly string WeaponQualityStandard = "Standard";
        public static readonly string WeaponQualityExcellent = "Excellent";

        // Weapon Cost Tier
        public static readonly string WeaponCostTierLow = "Low";
        public static readonly string WeaponCostTierMedium = "Medium";
        public static readonly string WeaponCostTierHigh = "High";

        // Weapon Costs
        public static readonly int WeaponCostStandardQualityLow = 50;
        public static readonly int WeaponCostStandardQualityMedium = 100;
        public static readonly int WeaponCostStandardQualityHigh = 500;
        public static readonly int WeaponCostPoorQualityLow = 20;
        public static readonly int WeaponCostPoorQualityMedium = 50;
        public static readonly int WeaponCostPoorQualityHigh = 100;
        public static readonly int WeaponCostExcellentQualityLow = 100;
        public static readonly int WeaponCostExcellentQualityMedium = 500;
        public static readonly int WeaponCostExcellentQualityHigh = 1000;

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

        public static readonly List<Weapon> WeaponRepository = new()
        {
            new(WeaponTypeLightMelee, SkillMeleeWeapon, 1, 1, AmmoTypeNone, 2, true, WeaponCostTierLow),
            new(WeaponTypeMediumMelee, SkillMeleeWeapon, 2, 1, AmmoTypeNone, 2, true, WeaponCostTierLow),
            new(WeaponTypeHeavyMelee, SkillMeleeWeapon, 3, 2, AmmoTypeNone, 2, true, WeaponCostTierMedium),
            new(WeaponTypeVeryHeavyMelee, SkillMeleeWeapon, 4, 2, AmmoTypeNone, 1, true, WeaponCostTierHigh),
            new(WeaponTypeMediumPistol, SkillHandgun, 2, 1, AmmoTypeMediumPistol, 2, true, WeaponCostTierLow),
            new(WeaponTypeHeavyPistol, SkillHandgun, 3, 1, AmmoTypeHeavyPistol, 2, true, WeaponCostTierMedium),
            new(WeaponTypeVeryHeavyPistol, SkillHandgun, 4, 1, AmmoTypeVeryHeavyPistol, 1, false, WeaponCostTierMedium),
            new(WeaponTypeSmg, SkillHandgun, 2, 1, AmmoTypeMediumPistol, 1, true, WeaponCostTierMedium),
            new(WeaponTypeHeavySmg, SkillHandgun, 3, 1, AmmoTypeHeavyPistol, 1, false, WeaponCostTierMedium),
            new(WeaponTypeShotgun, SkillShoulderArms, 5, 2, AmmoTypeSlug, 1, false, WeaponCostTierHigh),
            new(WeaponTypeAssaultRifle, SkillShoulderArms, 5, 2, AmmoTypeRifle, 1, false, WeaponCostTierHigh),
            new(WeaponTypeSniperRifle, SkillShoulderArms, 5, 2, AmmoTypeRifle, 1, false, WeaponCostTierHigh),
            new(WeaponTypeBowsAndCrossbows, SkillArchery, 4, 2, AmmoTypeArrow, 1, false, WeaponCostTierMedium),
            new(WeaponTypeGrenadeLauncher, SkillHeavyWeapons, 6, 2, AmmoTypeGrenade, 1, false, WeaponCostTierHigh),
            new(WeaponTypePopupGrenadeLauncher, SkillHeavyWeapons, 6, 1, AmmoTypeGrenade, 1, true, WeaponCostTierHigh),
            new(WeaponTypeRocketLauncher, SkillHeavyWeapons, 8, 2, AmmoTypeRocket, 1, false, WeaponCostTierHigh),
            new(WeaponTypeDartgun, SkillHandgun, 2, 1, AmmoTypeDart, 1, true, WeaponCostTierMedium),
            new(WeaponTypeFlamethrower, SkillHeavyWeapons, 1, 2, AmmoTypeIncendiaryShell, 1, false, WeaponCostTierHigh)
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
        public static readonly Dictionary<string, string> MasterGearList = new()
        {
            { GearAgent, "Self-adaptive-AI powered smartphone; that \"learns\" how best to fit your needs simply by interacting with you. While not a true AI, it is more than capable of replacing any need for a secretary. When you sit back and allow your Agent to manage your life, everything is easier, including making sure you have time to do what you need to do (crimes, killing people, getting away with it, and so forth) instead of going to the store to get something you forgot. There are many reasons why almost everyone has one." },
            { GearAirhypo, "Easy to use drug distribution platform which uses a quick burst of compressed air to force a drug through the skin. Allows user to use an Action to administer a single dose of a desired drug to a willing target, or try to make a Melee Weapon Attack to administer a single dose to an unwilling target on a hit instead of dealing damage. Reloading the Airhypo with a dose of your desired drug isn't an Action." },
            { GearAntiSmogBreathingMask, "Useful for filtering out toxins and smoke from the local environment. User is immune to the effects of toxic gasses, fumes, and all similar dangers that must be inhaled to affect the user." },
            { GearAudioRecorder, "Device records up to 24 hours of audio before its output fills up a standard Memory Chip stored in the device." },
            { GearAutoLevelDampeningEarProtectors, "Compact ear protection. When worn, user is immune to deafness or other effects caused by dangerously loud noises, like those produced by a flashbang." },
            { GearBinoculars, "You look through them. They double or triple the size of what you are seeing." },
            { GearBraindanceViewer, "Allows the user to experience braindance content. Braindances are digital recordings of an experience which you view through the eyes of the actor. The experience includes all the subject's senses, and you feel every emotion felt, for better or worse." },
            { GearBugDetector, "Device beeps when user is within 2m/yds of a tap, bug, or other listening device." },
            { GearCarryall, "Heavy ripstop nylon bags of varying sizes, from messenger to nearly man-sized duffel bags." },
            { GearChemicalAnalyzer, "Can test substances as an Action to find their precise chemical composition, identifying most substances instantly from a wide database of samples." },
            { GearComputer, "Laptop or desktop computer, used mostly for comfortable word processing and surfing the Data Pool." },
            { GearCryopump, "A Cryopump is a briefcase-sized tool containing a body bag hooked up to a powerful pump. Once willing/unconscious targets have been placed into the bag and hooked up to the pump as an Action, the pump forces a hyper-cooled chemical fluid into the bag, draining one of the Cryopump's charges per target put in stasis (one per person, if the Cryopump can accept multiple people). While in stasis, targets are unconscious and no longer roll any Death Saves for up to a week, as long as they remain inside the bag and the bag has at least 1 HP. A Character in a cryopump bag is considered to be behind a piece of cover that has 15 HP. The bag's transparent top and gloves molded into the lining allow the target to undergo surgery and be stabilized while in stasis, which is much less dangerous to the patient. A standard Cryopump has only 1 charge and can only hold a single roughly humansized target. Refueling a Cryopump costs 50eb (Costly) per charge. A Character who is not a Medtech cannot operate a Cryopump." },
            { GearCryotank, "A Cryotank is a human-sized container which can hold a fully grown adult. Assuming the Medtech succeeds at a DV13 Medical Tech Check, the Cryotank keeps 1 person in stasis as long as desired. While in the Cryotank, they are considered to be unconscious, but they heal at double the normal rate as long as they remain inside the tank and the tank has at least 1 HP. A Character in a Cryotank is considered to be behind a piece of cover that has 30 HP. A Character who is not a Medtech cannot operate a Cryotank." },
            { GearCyberdeckExcellent, "A high-end modular platform that Programs and Hardware are installed on for the purpose of Netrunning. This cyberdeck has 9 slots to install Programs and Hardware. Requires Interface Plugs and Neural Link for a Netrunner to operate." },
            { GearCyberdeckPoor, "A cheap modular platform that Programs and Hardware are installed on for the purpose of Netrunning. This cyberdeck has 5 slots to install Programs and Hardware. Requires Interface Plugs and Neural Link for a Netrunner to operate." },
            { GearCyberdeckStandard, "Modular platform that Programs and Hardware are installed on for the purpose of Netrunning. This cyberdeck has 7 slots to install Programs and Hardware. Requires Interface Plugs and Neural Link for a Netrunner to operate." },
            { GearDisposableCellPhone, "There are still billions of the things around. A good choice for Fixers and other people who don't want to be tracked." },
            { GearDrumSynthesizer, "Flat plastic pads of varying sizes, linked by cables to a central processor. Can simulate almost any kind of drum. Requires some type of amplification to be heard." },
            { GearDuctTape, "Comes in many colors and optionally can glow in the dark. Glowing duct tape is often used to mark tunnels, dead drops, or caches. It glows in the dark even if there has been no light exposure." },
            { GearElectricGuitar, "Use your imagination. But remember that you will need an amp to be heard with any electronic-based instrument." },
            { GearFlashlight, "Rechargeable. 100m/yd beam, lasts up to 10 hours on a charge." },
            { GearFoodStick, "Grainy, dried food bar that comes in a variety of (awful) flavors. One meal." },
            { GearGlowPaint, "Glow in the dark paint for marking locations and creating art. Comes in a spray can. Also good for tagging." },
            { GearGlowStick, "Light tube to illuminate a 4m/yd area for up to 10 hours. One use only" },
            { GearGrappleGun, "When wielded in a hand, user as an Action can fire a rocket propelled grapple that will attach securely to any \"thick\" cover up to 30m/yds away. Line can only support two times the user's body weight, and has 10 HP. The user negates the normal movement penalty for climbing when they climb this line, and can retract the line without an Action, including as they climb. When used as a grapple, user can't hold anything in the hand used to wield the grapple gun. Ineffective as a weapon, and cannot be used to make the Grab Action." },
            { GearHandcuffs, "Book 'em, Danno. Can be broken easily if your BODY is higher than 10." },
            { GearHomingTracer, "Device can follow a linked tracer up to 1-mile away. Comes with a free button sized linked tracer. Replacement linked tracers are 50eb." },
            { GearInflatableBed, "It's a self-inflating air mattress than comes packed with a thin sleeping bag. The whole thing folds to a 6\"x6\" package for easy storage." },
            { GearKibblePack, "One foil package of dry, pet food-like cereal or wafers equivalent to a single meal. Usually identified by number rather than the fake appetizing label and description." },
            { GearLinearFrameBeta, "Powered exoskeleton, giving the user tremendous strength. • User increases their BODY to 14 while plugged into the frame. This cannot increase the user's BODY to 15 or higher. This increase in BODY does not increase the user's HP or change their Death Save. • Requires 2 installation of Interface Plugs to operate." },
            { GearLinearFrameSigma, "Powered exoskeleton, giving the user even more tremendous strength. • User increases their BODY to 12 while plugged into the frame using two installations of Interface Plugs. This cannot increase the user's BODY to 13 or higher. This increase in BODY does not increase the user's HP or change their Death Save. • Requires 1 installations of Interface Plugs to operate." },
            { GearLockPickingSet, "A small pouch of tools for cracking mechanical locks." },
            { GearMedscanner, "Scanner with external probes and contacts that diagnoses injury and illness, assisting user in medical emergencies not requiring Surgery. User adds +2 to their First Aid and Paramedic Skills. This doesn't stack with itself" },
            { GearMedtechBag, "Medical toolkit that includes everything from dermal staplers to spray skin applicators to sterile scalpels. All you need to save lives using your skills and training." },
            { GearMemoryChips, "Thin wafers of doped plastic that store information in all forms. Some of these are larger than others." },
            { GearMRE, "Self-heating plastic and foil meal bag. Add water, snap the tab on the top, and in 2 minutes you have something that resembles a single hot, nourishing meal." },
            { GearPersonalCarePak, "Toothpaste-loaded toothbrush, all body wet-wipes, depilatory paste, comb, etc." },
            { GearPocketAmplifier, "About the size of a large book, this rechargeable amplifier delivers sound up to 100m/yd for up to 6 hours. Can support two instruments" },
            { GearRadarDetector, "Device beeps if an active radar beam is present within 100m/yds." },
            { GearRadioCommunicator, "Earpiece allowing user to communicate via radio, 1-mile range." },
            { GearRadioScannerMusicPlayer, "Music player can link to the Data Pool to listen to the hottest music, or play directly from a Memory Chip. User can also scan all radio bands within a mile that are currently being used and tune into them, though some channels might require a Descrambler to understand." },
            { GearRoadFlare, "Lights an area of 100m/yards for 1 hour. Different colors. One use." },
            { GearRope, "Nylon rope. Can come in colors if desired. Holds up to 800lbs (360kg)." },
            { GearScramblerDescrambler, "Allows user to scramble outgoing communications so they cannot be understood without a descrambler, which is also included at no extra charge." },
            { GearSmartGlasses, "Contains two option slots for Cybereye options. When worn, Smart Glasses give the user access to the benefits of these options. When cybereye options are installed into the glasses, they always count as if they were paired, and it costs the same as installing the option once in a cybereye. You can only wear a single pair at a time. Enthusiasts often replace the frames of their Smart Glasses with nicer ones, as they aren't the prettiest out of the box." },
            { GearTechBag, "Small bag of tools for fixing electronics and machines. Includes a Techtool, electrical parts like tape and wire wraps, asst. screws and bolts, plug in modules for repairs, heat torch, 2 small prybars, and hammer." },
            { GearTechscanner, "Scanner diagnoses a wide variety of machinery and electronics, assisting the user in repairs, or other technical work. User adds +2 to their Basic Tech, Cybertech, Land Vehicle Tech, Sea Vehicle Tech, Air Vehicle Tech, Electronics/Security Tech, and Weaponstech Skills. This doesn't stack with itself." },
            { GearTechtool, "Small bag of tools for fixing electronics and machines. Includes a Techtool, electrical parts like tape and wire wraps, asst. screws and bolts, plug in modules for repairs, heat torch, 2 small prybars, and hammer." },
            { GearTentAndCampingEquipment, "Small one-person tube tent with plastic stakes, one self-heating, rechargeable pot to boil water (takes 5 min to recharge, lasts 2 hours) and a cheap metal spork that couldn't hurt a fly." },
            { GearVialOfBiotoxin, "An entire vial of biotoxin can be smeared on any Light Melee Weapon as an Action. For the next 30 minutes after application, instead of dealing the weapon's typical damage, anyone meat hit by the biotoxin-coated Light Melee Weapon must instead attempt to beat a DV15 Resist Torture/Drugs Check. Anyone who fails is dealt 3d6 damage directly to their HP. Their armor isn't ablated because it wasn't interacted with." },
            { GearVialOfPoison, "An entire vial of poison can be smeared on any Light Melee Weapon as an Action. For the next 30 minutes after application, instead of dealing the weapon's typical damage, anyone meat hit by the poisoned Light Melee Weapon must instead attempt to beat a DV13 Resist Torture/Drugs Check. Anyone who fails is dealt 2d6 damage directly to their HP. Their armor isn't ablated because it wasn't interacted with." },
            { GearVideoCamera, "When held in a hand, user can record up to 12 hours of video and audio before its output fills up a standard Memory Chip stored in the device." },
            { GearVirtualityGoggles, "Headset that projects cyberspace imagery over your view of the world around you. Highly advised for Netrunners." },
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

        public static readonly Dictionary<string, string> MasterCyberwareList = new()
        {
            // Fashionware
            { CyberwareBiomonitor, "Subdermal implant which generates a readout of vitals. Can link to Agent." },
            { CyberwareChemskin, "Dyes and pigments infused into the skin to permanently change its hue. +2 to Personal Grooming if user also has Techhair." },
            { CyberwareEmpThreading, "Thin silver lines that run in circuit-like patterns across the body." },
            { CyberwareLightTattoo, "Subdermal patches store light and project colored tattoos under the skin. +2 to Wardrobe and Style if user has three or more tattoos." },
            { CyberwareShiftTacts, "Color-changing lenses implanted into the eye." },
            { CyberwareSkinwatch, "Subdermally implanted LED watch." },
            { CyberwareTechhair, "Color-light-emitting artificial hair. +2 to Personal Grooming if user also has Chemskin." },

            // Neuralware
            { CyberwareNeuralLink, "Wired artificial nervous system. Required to use Neuralware and Subdermal Grip. Has 5 Option Slots." },
            { CyberwareBraindanceRecorder, "Records user's experiences to memory chip or external device. Requires Neural Link." },
            { CyberwareChipwareSocket, "A single socket installed in back of the neck. Required to use Chipware. Requires Neural Link." },
            { CyberwareInterfacePlugs, "Plugs in wrist or head that allow connection to machines. Requires Neural Link." },
            { CyberwareKerenzikov, "Speedware. User adds +2 to Initiative. Only 1 piece of Speedware can be installed at a time. Requires Neural Link." },
            { CyberwareSandevistan, "Speedware. When activated as an Action adds +3 to Initiative for one minute. Has 1 hour cool down period. Only 1 piece of Speedware can be installed at a time. Requires Neural Link." },
            { CyberwareChemicalAnalyzer, "Chipware. Tests substance for precise chemical composition and compares to a database. Requires Chipware Socket." },
            { CyberwareMemoryChip, "Data storage. User's cyberware can store or access data on it." },
            { CyberwareOlfactoryBoost, "Chipware. User can use Tracking Skill to track via scent. Requires Chipware Socket." },
            { CyberwarePainEditor, "Chipware. User ignores penalties due to being Seriously Wounded. Requires Chipware Socket." },
            { CyberwareSkillChip, "Chipware. User has specific Skill at Level 3 unless Skill is already 3+. Skill Chips for (x2) cost Skills cost more. Requires Chipware Socket." },
            { CyberwareTactileBoost, "Chipware. User can detect motion within 20m/yd by placing hand on surface. Requires Chipware Socket." },

            // Cyberoptics
            { CyberwareCybereye, "Artificial Eye. Each Cybereye has 3 Option Slots. Some options must be paired (purchased twice and installed in two different Cybereyes on a user. HL must be paid for each)." },
            { CyberwareAntiDazzle, "User immune to effects caused by flashes of light. Requires two Cybereyes and must be paired." },
            { CyberwareChyron, "Projects subscreen into user's field of vision. Requires a Cybereye." },
            { CyberwareColorShift, "Unlimited color and pattern changes for the eye. Requires a Cybereye." },
            { CyberwareDartgun, "Single shot Dartgun Exotic Weapon concealed in eye. Requires a Cybereye and takes 3 Option Slots." },
            { CyberwareImageEnhance, "Adds +2 to Perception, Lip Reading, and Conceal/Reveal Object. Requires two Cybereyes and must be paired." },
            { CyberwareLowLightInfraredUv, "User can ignore penalties due to darkness, smoke, fog, etc. Requires two Cybereyes, must be paired, and takes 2 Option Slots per Cybereye." },
            { CyberwareMicroOptics, "Provides user with 400x magnification. Requires a Cybereye." },
            { CyberwareMicroVideo, "Camera in eye. Records audio and video to Memory Chip or linked Agent. Requires a Cybereye and takes 2 Option Slots." },
            { CyberwareRadiationDetector, "Radiation readings within 100m/yds displayed in form of blue glow. Requires a Cybereye." },
            { CyberwareTargetingScope, "Adds +1 to Check when making Aimed Shot. Requires a Cybereye." },
            { CyberwareTeleOptics, "Can see detail up to 800m/yd away. +1 to Aimed Shots against target 51m/yds or farther away. Requires a Cybereye." },
            { CyberwareVirtuality, "Projects cyberspace imagery over user's view of the world. Requires two Cybereyes and must be paired." },

            // Cyberaudio
            { CyberwareCyberaudioSuite, "Has 3 Option Slots. Cannot install more than 1." },
            { CyberwareAmplifiedHearing, "+2 to Perception for Checks involving hearing. Requires a Cyberaudio Suite." },
            { CyberwareAudioRecorder, "Records audio to Memory Chip or linked Agent. Requires a Cyberaudio Suite." },
            { CyberwareBugDetector, "Beeps when within 2m/yds of a listening device. Requires a Cyberaudio Suite." },
            { CyberwareHomingtracer, "Can follow a linked tracer up to 1 mile away. Requires a Cyberaudio Suite." },
            { CyberwareInternalAgent, "Fully functional Agent installed internally. Can be linked to a Cybereye with Chyron display. Otherwise, audio only. Requires a Cyberaudio Suite." },
            { CyberwareLevelDamper, "User immune to effects caused by loud noises. Requires a Cyberaudio Suite." },
            { CyberwareRadioCommunicator, "User can communicate via radio. 1 mile range. Requires a Cyberaudio Suite." },
            { CyberwareRadioScannerMusicPlayer, "Can play music from Data Pool or Memory Chip or tune into radio broadcasts within 1 mile. Requires a Cyberaudio Suite." },
            { CyberwareRadarDetector, "Beeps if active radar beam is within 100m/yd. Requires a Cyberaudio Suite." },
            { CyberwareScramblerDescrambler, "Allows user to scramble outgoing communications and descramble incoming communications. Requires a Cyberaudio Suite." },
            { CyberwareVoiceStressAnalyzer, "+2 to Human Perception and Interrogation Checks. Requires a Cyberaudio Suite." },

            // Internal Cyberware
            { CyberwareAudioVox, "Voice synthesizer. Adds +2 to Acting and Play Instrument when singing." },
            { CyberwareContraceptiveImplant, "Prevents undesired pregnancy." },
            { CyberwareEnhancedAntibodies, "After stabilization, user heals BODY x 2 for each day spent resting." },
            { CyberwareCybersnake, "Esophagus mounted Very Heavy Melee Weapon. Can be concealed." },
            { CyberwareGills, "User can breathe underwater." },
            { CyberwareGraftedMuscleBoneLace, "Increases BODY by 2. The increase changes HP, Wound Threshold, and Death Save. Cannot raise BODY above 10." },
            { CyberwareIndependentAirSupply, "Provides 30 minutes of oxygen. Takes 1 hour to refill from ambient atmosphere." },
            { CyberwareMidnightLady, "Be a Venus, be the fire, be desire." },
            { CyberwareMrStudd, "All night, every night, and they'll never know." },
            { CyberwareNasalFilters, "User immune to effects of toxic gases, fumes, and similar dangers." },
            { CyberwareRadarSonarImplant, "Scans terrain within 50m/yds. Cannot scan through cover." },
            { CyberwareToxinBinders, "Adds +2 to Resist Torture/Drugs." },
            { CyberwareVampyres, "Excellent Quality Light Melee Weapon implanted in mouth. Can be concealed. User can add Poison or Biotoxin." },

            // External Cyberware
            { CyberwareHiddenHolster, "Can store weapon capable of concealment inside body." },
            { CyberwareSkinWeave, "User's body and head armored at SP7. Does not stack with worn Armor. Ablates. Recovers 1 SP per day of rest." },
            { CyberwareSubdermalArmor, "User's body and head armored at SP11. Does not stack with worn Armor. Ablates. Recovers 1 SP per day of rest." },
            { CyberwareSubdermalPocket, "2\" x 4\" (5cm x 10cm) storage space just under the skin with RealSkinn™ zipper." },

            // Cyberlimbs - Arms
            { CyberwareCyberarm, "Replacement arm. Has 4 Option Slots. Comes installed with Standard Hand that doesn't cause Humanity Loss or take up an Option Slot." },
            { CyberwareStandardHand, "Standard cybernetic hand. Can be installed in a meat arm." },
            { CyberwareBigKnucks, "Armored knuckles. Medium Melee Weapon. Can be concealed. Can be installed as only piece of Cyberware in a meat arm." },
            { CyberwareCyberdeck, "Cyberdeck installed in Cyberarm. Requires a Cyberarm and takes up 3 Option Slots." },
            { CyberwareGrappleHand, "Fires hand, along with a grapple line up to 30m/yds. Cannot be used as a weapon. Requires a Cyberarm." },
            { CyberwareMedscanner, "Medscanner installed in Cyberarm. Helps diagnose illness and injury. +2 to First Aid and Paramedic. Requires a Cyberarm and takes 2 Option Slots." },
            { CyberwarePopupGrenadeLauncher, "A single shot Grenade Launcher installed in a Cyberarm. Weapon can be concealed. Requires a Cyberarm and takes up 2 Option Slots." },
            { CyberwarePopupMeleeWeapon, "Any Light, Medium, or Heavy Melee Weapon installed in a Cyberarm. Weapon can be concealed even if not normally concealable. Requires a Cyberarm and takes up 2 Option Slots." },
            { CyberwarePopupShield, "A Bulletproof Shield installed in the Cyberarm. Can be concealed and replaced when at 0 HP. Requires a Cyberarm and takes up 3 Option Slots." },
            { CyberwarePopupRangedWeapon, "Any One Handed Ranged Weapon installed in a Cyberarm. Weapon can be concealed even if not normally concealable. Requires a Cyberarm and takes up 2 Option Slots." },
            { CyberwareQuickChangeMount, "Allows user to remove or install a Cyberarm as an Action." },
            { CyberwareRippers, "Carbo-glass claws. Medium Melee Weapon. Can be concealed. Can be installed as only piece of Cyberware in a meat arm." },
            { CyberwareScratchers, "Carbo-glass fingernails. Light Melee Weapon. Can be concealed. Can be installed as only piece of Cyberware in a meat arm." },
            { CyberwareShoulderCam, "Video camera mounted in shoulder. Can be concealed. Requires a Cyberarm and takes up 2 Option Slots." },
            { CyberwareSliceAndDice, "Monofilament whip implanted in the thumb. Medium Melee Weapon. Can be concealed. Can be installed as only piece of Cyberware in a meat arm." },
            { CyberwareSubdermalGrip, "Allows user to use Smartgun without Interface Plug. Can be installed as only piece of Cyberware in a meat arm. Requires Neural Link." },
            { CyberwareTechscanner, "Techscanner installed in Cyberarm. Helps diagnose broken tech. +2 to multiple TECH-based Skills. Requires a Cyberarm and takes 2 Option Slots." },
            { CyberwareToolHand, "Fingers contain screwdriver, wrench, small drill, and other tools. Can be installed as only piece of Cyberware in a meat arm." },
            { CyberwareWolvers, "Long claws extended from the knuckles. Heavy Melee Weapon. Can be concealed. Can be installed as only piece of Cyberware in a meat arm." },

            // Cyberlimbs - Legs
            { CyberwareCyberleg, "Replacement leg. Has 3 Option Slots. Comes installed with Standard Foot that doesn't cause Humanity Loss or take up an Option Slot. Most Cyberleg options must be paired (purchased twice and installed in two different Cyberlegs on a user. HL must be paid for each)." },
            { CyberwareStandardFoot, "Standard cybernetic foot. Can be installed in a meat leg." },
            { CyberwareGripFoot, "Traction enhanced. Negates movement penalty when climbing. Requires two Cyberlegs and must be paired." },
            { CyberwareJumpBooster, "Hydraulics in legs. Negates movement penalty when jumping. Requires two Cyberlegs, takes up 2 Option Slots, and must be paired." },
            { CyberwareSkateFoot, "Inline skates built into feet. Can be concealed. Increases movement by 6m/yds when using Run Action. Requires two Cyberlegs and must be paired." },
            { CyberwareTalonFoot, "Blade mounted in foot. Light Melee Weapon. Can be concealed. Can be installed as the only piece of Cyberware in a meat leg." },
            { CyberwareWebFoot, "Thin webbing between toes. Negates movement penalty when swimming. Requires Two Cyberlegs and must be paired." },

            // Cyberlimbs - Misc
            { CyberwareHardenedShielding, "Cyberlimb and installed options cannot be rendered inoperable by EMP pulses or Non-Black ICE Program effects. Requires Cyberarm or Cyberleg." },
            { CyberwarePlasticCovering, "Plastic coating for Cyberlimb. Available in wide variety of colors and patterns. Requires a Cyberarm or Cyberleg but does not take an Option Slot." },
            { CyberwareRealskinnCovering, "Artificial skin coating for Cyberlimb. Requires a Cyberarm or Cyberleg but does not take an Option Slot." },
            { CyberwareSuperchromeCovering, "Shiny metallic coating for Cyberlimb. +2 to Wardrobe and Style. Requires a Cyberarm or Cyberleg but does not take an Option Slot." },

            // Borgware
            { CyberwareArtificialShoulderMount, "User can mount 2 Cyberarms under first set of arms." },
            { CyberwareImplantedLinearFrameBeta, "Enhanced skeleton and support structure. Increases BODY to 14. The increase changes HP, Wound Threshold, and Death Save. Requires BODY 8 and 2 Grafted Muscles and Bone Lace." },
            { CyberwareImplantedLinearFrameSigma, "Enhanced skeleton and support structure. Increases BODY to 12. The increase changes HP, Wound Threshold, and Death Save. Requires BODY 6 and Grafted Muscles and Bone Lace." },
            { CyberwareMultiOpticMount, "User can mount up to 5 additional Cybereyes." },
            { CyberwareSensorArray, "User can install up to 5 additional Cyberaudio Options. Requires Cyberaudio Suite but does not take up Cyberaudio Option Slot." },

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

        // TODO - program portraits
        public static readonly List<CyberdeckProgram> CyberdeckPrograms = new()
        {
            new(ProgramEraser, PortraitAssassin, ProgramClassBooster, 0, 0, 7, "Increases all CLoak Checks you make by +2 as long as this Program remains Rezzed."),
            new(ProgramSeeYa, PortraitAssassin, ProgramClassBooster, 0, 0, 7, "Increases all Pathfinder Checks you make by +2 as long as this Program remains Rezzed"),
            new(ProgramSpeedyGonzalvez, PortraitAssassin, ProgramClassBooster, 0, 0, 7, "Increases you Speed by +2 as long as this Program remains rezzed"),
            new(ProgramWorm, PortraitAssassin, ProgramClassBooster, 0, 0, 7, "Increases all Backdoor Checks you make by +2 as long as this Program remains Rezzed"),

            new(ProgramArmor, PortraitAssassin, ProgramClassDefender, 0, 0, 7, "Lowers all brain damage you would receive by 4, as long as this Program remains Rezzed. Only 1 copy of this Program can be running at a time. Each copy of this Program can only be used once per Netrun."),
            new(ProgramFlak, PortraitAssassin, ProgramClassDefender, 0, 0, 7, "Reduces the ATK of all Non-Black ICE Attacker Programs run against you to 0 as long as this Program remains Rezzed. Only 1 copy of this Program can be running at a time. Each copy of this Program can only be used once per Netrun."),
            new(ProgramShield, PortraitAssassin, ProgramClassDefender, 0, 0, 7, "Stops the first successful Non-Black ICE Program Effect from dealing brain damage. After stopping this damage, the Shield Derezzes itself. Only 1 copy of this Program can be running at a time. Each copy of this Program can only be used once per Netrun."),

            new(ProgramBanhammer, PortraitAssassin, ProgramClassAntiProgramAttacker, 1, 0, 0, "Does 3d6 REZ to a Non-Black ICE Program, or 2d6 REZ to a Black ICE Program."),
            new(ProgramSword, PortraitAssassin, ProgramClassAntiProgramAttacker, 1, 0, 0, "Does 3d6 REZ to a Black ICE Program, or 2d6 REZ to a Non-Black ICE Program."),
            new(ProgramDeckKrash, PortraitAssassin, ProgramClassAntiPersonnelAttacker, 0, 0, 0, "Enemy Netrunner is forcibly and unsafely Jacked Out of the Architecture, suffering the effect of all Rezzed enemy Black ICE they've encountered in the Architecture as they leave."),
            new(ProgramHellbolt, PortraitAssassin, ProgramClassAntiPersonnelAttacker, 2, 0, 0, "Does 2d6 Damage direct to the enemy Netrunner's brain. Unless insulated, their Cyberdeck catches fire along with their clothing. Until they spend a Meat Action to put themselves out, they take 2 damage to their HP whenever they end their Turn. Multiple instances of this effect cannot stack."),
            new(ProgramNervescrub, PortraitAssassin, ProgramClassAntiPersonnelAttacker, 0, 0, 0, "Enemy Netrunner's INT, REF, and DEX are each lowered by 1d6 for the next hour (minimum 1). The effects are largely psychosomatic and leave no permanent effects."),
            new(ProgramPoisonFlatline, PortraitAssassin, ProgramClassAntiPersonnelAttacker, 0, 0, 0, "Destroys a single Non-Black ICE Program installed on the Netrunner target's Cyberdeck at random."),
            new(ProgramSuperglue, PortraitAssassin, ProgramClassAntiPersonnelAttacker, 2, 0, 0, "Enemy Netrunner cannot progress deeper into the Architecture or Jack Out safely for 1d6 Rounds (enemy Netrunner can still perform an unsafe Jack Out, though). Each copy of this Program can only be used once per Netrun."),
            new(ProgramVrizzbolt, PortraitAssassin, ProgramClassAntiPersonnelAttacker, 1, 0, 0, "Does 1d6 Damage direct to a Netrunner's brain and lowers the amount of total NET Actions the Netrunner can accomplish on their next Turn by 1 (minimum 2).")
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
            #region Bodyguard
            Combatant bodyguard = new("Bodyguard", PortraitBodyguard, ArmorTypeKevlar);
            bodyguard.SetStats(3, 6, 5, 2, 4, 4, 0, 4, 6, 3);
            bodyguard.SetCalculatedStats();
            bodyguard.SetBaseSkills();
            bodyguard.AddSkill(SkillAthletics, 9);
            bodyguard.AddSkill(SkillBrawling, 11);
            bodyguard.AddSkill(SkillConcentration, 6);
            bodyguard.AddSkill(SkillConversation, 5);
            bodyguard.AddSkill(SkillDriveLandVehicle, 10);
            bodyguard.AddSkill(SkillEducation, 5);
            bodyguard.AddSkill(SkillEndurance, 9);
            bodyguard.AddSkill(SkillEvasion, 7);
            bodyguard.AddSkill(SkillFirstAid, 4);
            bodyguard.AddSkill(SkillHandgun, 10);
            bodyguard.AddSkill(SkillHumanPerception, 5);
            bodyguard.AddSkill(SkillInterrogation, 6);
            bodyguard.AddSkill(SkillLanguage, 5, LanguageNative);
            bodyguard.AddSkill(SkillLanguage, 5, LanguageStreetslang);
            bodyguard.AddSkill(SkillLocalExpert, 5, LocalExpertYourHome);
            bodyguard.AddSkill(SkillPerception, 9);
            bodyguard.AddSkill(SkillPersuasion, 6);
            bodyguard.AddSkill(SkillResistTortureDrugs, 8);
            bodyguard.AddSkill(SkillShoulderArms, 10);
            bodyguard.AddSkill(SkillStealth, 7);
            bodyguard.AddWeapon(WeaponTypeShotgun, WeaponQualityPoor);
            bodyguard.AddWeapon(WeaponTypeVeryHeavyPistol, WeaponQualityStandard);
            bodyguard.AddAmmo(AmmoTypeSlug, 25);
            bodyguard.AddAmmo(AmmoTypeVeryHeavyPistol, 25);
            bodyguard.AddGearSet(GearRadioCommunicator);
            bodyguard.InitializeNewCombatant();
            Combatants.Add(bodyguard);
            #endregion
            #region Boosterganger
            Combatant boosterganger = new("Boosterganger", PortraitBoosterganger, ArmorTypeLeather);
            boosterganger.SetStats(2, 6, 5, 2, 4, 2, 0, 4, 4, 3);
            boosterganger.SetCalculatedStats();
            boosterganger.SetBaseSkills();
            boosterganger.AddSkill(SkillAthletics, 9);
            boosterganger.AddSkill(SkillBrawling, 9);
            boosterganger.AddSkill(SkillConcealRevealObject, 4);
            boosterganger.AddSkill(SkillConcentration, 4);
            boosterganger.AddSkill(SkillConversation, 5);
            boosterganger.AddSkill(SkillDriveLandVehicle, 10);
            boosterganger.AddSkill(SkillEducation, 4);
            boosterganger.AddSkill(SkillEndurance, 6);
            boosterganger.AddSkill(SkillEvasion, 7);
            boosterganger.AddSkill(SkillFirstAid, 4);
            boosterganger.AddSkill(SkillHandgun, 12);
            boosterganger.AddSkill(SkillHumanPerception, 5);
            boosterganger.AddSkill(SkillInterrogation, 6);
            boosterganger.AddSkill(SkillLanguage, 4, LanguageNative);
            boosterganger.AddSkill(SkillLanguage, 4, LanguageStreetslang);
            boosterganger.AddSkill(SkillLocalExpert, 4, LocalExpertYourHome);
            boosterganger.AddSkill(SkillMeleeWeapon, 11);
            boosterganger.AddSkill(SkillPerception, 6);
            boosterganger.AddSkill(SkillPersuasion, 6);
            boosterganger.AddSkill(SkillResistTortureDrugs, 4);
            boosterganger.AddSkill(SkillStealth, 7);
            boosterganger.AddWeapon(WeaponTypeVeryHeavyPistol, WeaponQualityPoor);
            boosterganger.AddWeapon(WeaponTypeMediumMelee, WeaponQualityStandard, "Rippers");
            boosterganger.AddAmmo(AmmoTypeVeryHeavyPistol, 30);
            boosterganger.AddGearSet(GearDisposableCellPhone);
            boosterganger.AddCyberwareSet(CyberwareRippers, CyberwareTechhair);
            boosterganger.InitializeNewCombatant();
            Combatants.Add(boosterganger);
            #endregion
            #region Road Ganger
            Combatant roadGanger = new("Road Ganger", PortraitRoadGanger, ArmorTypeLeather);
            roadGanger.SetStats(4, 6, 4, 4, 3, 3, 0, 3, 3, 3);
            roadGanger.SetCalculatedStats();
            roadGanger.SetBaseSkills();
            roadGanger.AddSkill(SkillArchery, 10);
            roadGanger.AddSkill(SkillAthletics, 10);
            roadGanger.AddSkill(SkillBrawling, 6);
            roadGanger.AddSkill(SkillConcentration, 5);
            roadGanger.AddSkill(SkillConversation, 6);
            roadGanger.AddSkill(SkillDriveLandVehicle, 12);
            roadGanger.AddSkill(SkillEducation, 6);
            roadGanger.AddSkill(SkillEndurance, 5);
            roadGanger.AddSkill(SkillEvasion, 6);
            roadGanger.AddSkill(SkillFirstAid, 6);
            roadGanger.AddSkill(SkillHandgun, 10);
            roadGanger.AddSkill(SkillHumanPerception, 5);
            roadGanger.AddSkill(SkillLandVehicleTech, 10);
            roadGanger.AddSkill(SkillLanguage, 6, LanguageNative);
            roadGanger.AddSkill(SkillLanguage, 6, LanguageStreetslang);
            roadGanger.AddSkill(SkillLocalExpert, 6, LocalExpertYourHome);
            roadGanger.AddSkill(SkillMeleeWeapon, 8);
            roadGanger.AddSkill(SkillPerception, 6);
            roadGanger.AddSkill(SkillPersuasion, 5);
            roadGanger.AddSkill(SkillStealth, 8);
            roadGanger.AddSkill(SkillTracking, 8);
            roadGanger.AddSkill(SkillWildernessSurvival, 8);
            roadGanger.AddWeapon(WeaponTypeVeryHeavyPistol, WeaponQualityStandard);
            roadGanger.AddWeapon(WeaponTypeBowsAndCrossbows, WeaponQualityStandard, "Crossbow");
            roadGanger.AddWeapon(WeaponTypeLightMelee, WeaponQualityStandard, "Tomahawk");
            roadGanger.AddAmmo(AmmoTypeVeryHeavyPistol, 20);
            roadGanger.AddAmmo(AmmoTypeArrow, 20);
            roadGanger.AddGearSet(GearRope, GearFlashlight);
            roadGanger.AddCyberwareSet(CyberwareNeuralLink, CyberwareInterfacePlugs);
            roadGanger.InitializeNewCombatant();
            Combatants.Add(roadGanger);
            #endregion
            #region Security Operative
            Combatant securityOperative = new("Security Operative", PortraitSecurityOperative, ArmorTypeKevlar);
            securityOperative.SetStats(3, 7, 4, 2, 2, 3, 0, 3, 5, 3);
            securityOperative.SetCalculatedStats();
            securityOperative.SetBaseSkills();
            securityOperative.AddSkill(SkillAthletics, 8);
            securityOperative.AddSkill(SkillAutofire, 10);
            securityOperative.AddSkill(SkillBrawling, 6);
            securityOperative.AddSkill(SkillConcentration, 7);
            securityOperative.AddSkill(SkillConversation, 5);
            securityOperative.AddSkill(SkillEducation, 5);
            securityOperative.AddSkill(SkillEvasion, 6);
            securityOperative.AddSkill(SkillFirstAid, 4);
            securityOperative.AddSkill(SkillHandgun, 10);
            securityOperative.AddSkill(SkillHumanPerception, 5);
            securityOperative.AddSkill(SkillInterrogation, 6);
            securityOperative.AddSkill(SkillLanguage, 5, LanguageNative);
            securityOperative.AddSkill(SkillLanguage, 5, LanguageStreetslang);
            securityOperative.AddSkill(SkillLocalExpert, 5, LocalExpertYourHome);
            securityOperative.AddSkill(SkillMeleeWeapon, 6);
            securityOperative.AddSkill(SkillPerception, 5);
            securityOperative.AddSkill(SkillPersuasion, 4);
            securityOperative.AddSkill(SkillResistTortureDrugs, 5);
            securityOperative.AddSkill(SkillShoulderArms, 10);
            securityOperative.AddSkill(SkillStealth, 6);
            securityOperative.AddWeapon(WeaponTypeAssaultRifle, WeaponQualityPoor);
            securityOperative.AddWeapon(WeaponTypeVeryHeavyPistol, WeaponQualityStandard);
            securityOperative.AddWeapon(WeaponTypeMediumMelee, WeaponQualityStandard, "Baton");
            securityOperative.AddAmmo(AmmoTypeRifle, 40);
            securityOperative.AddAmmo(AmmoTypeVeryHeavyPistol, 20);
            securityOperative.AddGearSet(GearRadioCommunicator);
            securityOperative.InitializeNewCombatant();
            Combatants.Add(securityOperative);
            #endregion
            #region Netrunner
            Combatant netrunner = new("Netrunner", PortraitNetrunner, ArmorTypeBodyweightSuit); // todo - functionality for netrunner combatants
            netrunner.SetStats(7, 5, 4, 7, 4, 5, 0, 5, 3, 4);
            netrunner.SetCalculatedStats();
            netrunner.SetBaseSkills();
            netrunner.AddSkill(SkillInterface, 4);
            netrunner.AddSkill(SkillAthletics, 9);
            netrunner.AddSkill(SkillBasicTech, 13);
            netrunner.AddSkill(SkillBrawling, 6);
            netrunner.AddSkill(SkillConcealRevealObject, 11);
            netrunner.AddSkill(SkillConcentration, 9);
            netrunner.AddSkill(SkillConversation, 6);
            netrunner.AddSkill(SkillCryptography, 11);
            netrunner.AddSkill(SkillDeduction, 11);
            netrunner.AddSkill(SkillEducation, 11);
            netrunner.AddSkill(SkillElectronicsSecurityTech, 11);
            netrunner.AddSkill(SkillEvasion, 6);
            netrunner.AddSkill(SkillFirstAid, 9);
            netrunner.AddSkill(SkillForgery, 13);
            netrunner.AddSkill(SkillHandgun, 10);
            netrunner.AddSkill(SkillHumanPerception, 6);
            netrunner.AddSkill(SkillLanguage, 9, LanguageNative);
            netrunner.AddSkill(SkillLanguage, 9, LanguageStreetslang);
            netrunner.AddSkill(SkillLocalExpert, 13, LocalExpertYourHome);
            netrunner.AddSkill(SkillLibrarySearch, 9);
            netrunner.AddSkill(SkillPerception, 11);
            netrunner.AddSkill(SkillPersuasion, 6);
            netrunner.AddSkill(SkillPickLock, 11);
            netrunner.AddSkill(SkillResistTortureDrugs, 7);
            netrunner.AddSkill(SkillStealth, 8);
            netrunner.AddWeapon(WeaponTypeVeryHeavyPistol, WeaponQualityStandard);
            netrunner.AddAmmo(AmmoTypeVeryHeavyPistol, 50);
            netrunner.AddCyberwareSet(CyberwareNeuralLink, CyberwareInterfacePlugs);
            netrunner.AddGearSet(GearFlashlight, GearVirtualityGoggles);
            netrunner.AddCyberdeckPrograms(ProgramBanhammer, ProgramDeckKrash, ProgramEraser, ProgramHellbolt, ProgramShield, ProgramSword, ProgramWorm);
            netrunner.InitializeNewCombatant(); // TODO - add NET actions to standard actions, or to new collection
            Combatants.Add(netrunner);
            #endregion
            #region Reclaimer Chief
            Combatant reclaimerChief = new("Reclaimer Chief", PortraitReclaimerChief, ArmorTypeLightArmorjack);
            reclaimerChief.SetStats(3, 6, 6, 5, 4, 5, 0, 4, 6, 4);
            reclaimerChief.SetCalculatedStats();
            reclaimerChief.SetBaseSkills();
            reclaimerChief.AddSkill(SkillAthletics, 12);
            reclaimerChief.AddSkill(SkillBasicTech, 9);
            reclaimerChief.AddSkill(SkillBrawling, 8);
            reclaimerChief.AddSkill(SkillConcentration, 7);
            reclaimerChief.AddSkill(SkillConversation, 6);
            reclaimerChief.AddSkill(SkillDeduction, 7);
            reclaimerChief.AddSkill(SkillDriveLandVehicle, 10);
            reclaimerChief.AddSkill(SkillEducation, 5);
            reclaimerChief.AddSkill(SkillElectronicsSecurityTech, 9);
            reclaimerChief.AddSkill(SkillEndurance, 11);
            reclaimerChief.AddSkill(SkillEvasion, 8);
            reclaimerChief.AddSkill(SkillFirstAid, 7);
            reclaimerChief.AddSkill(SkillHandgun, 10);
            reclaimerChief.AddSkill(SkillHumanPerception, 6);
            reclaimerChief.AddSkill(SkillLandVehicleTech, 7);
            reclaimerChief.AddSkill(SkillLanguage, 5, LanguageNative);
            reclaimerChief.AddSkill(SkillLanguage, 5, LanguageStreetslang);
            reclaimerChief.AddSkill(SkillLocalExpert, 5, LocalExpertYourHome);
            reclaimerChief.AddSkill(SkillMeleeWeapon, 10);
            reclaimerChief.AddSkill(SkillParamedic, 7);
            reclaimerChief.AddSkill(SkillPerception, 8);
            reclaimerChief.AddSkill(SkillPersuasion, 6);
            reclaimerChief.AddSkill(SkillPickLock, 7);
            reclaimerChief.AddSkill(SkillResistTortureDrugs, 10);
            reclaimerChief.AddSkill(SkillShoulderArms, 10);
            reclaimerChief.AddSkill(SkillStealth, 10);
            reclaimerChief.AddSkill(SkillWeaponstech, 9);
            reclaimerChief.AddSkill(SkillWildernessSurvival, 7);
            reclaimerChief.AddWeapon(WeaponTypeShotgun, WeaponQualityStandard);
            reclaimerChief.AddWeapon(WeaponTypeHeavyPistol, WeaponQualityStandard);
            reclaimerChief.AddWeapon(WeaponTypeLightMelee, WeaponQualityStandard);
            reclaimerChief.AddWeapon(WeaponTypeHeavyMelee, WeaponQualityStandard);
            reclaimerChief.AddAmmo(AmmoTypeSlug, 25);
            reclaimerChief.AddAmmo(AmmoTypeHeavyPistol, 25);
            reclaimerChief.AddGearSet(GearAgent, GearGrappleGun, GearRadioCommunicator, GearTentAndCampingEquipment);
            reclaimerChief.AddCyberwareSet(CyberwareNasalFilters, CyberwareNeuralLink, CyberwareChipwareSocket, CyberwareTactileBoost);
            Combatants.Add(reclaimerChief);
            #endregion
            #region Security Officer
            Combatant securityOfficer = new("Security Officer", PortraitSecurityOfficer, ArmorTypeMediumArmorjack);
            securityOfficer.SetStats(4, 8, 6, 4, 6, 5, 0, 6, 7, 4);
            securityOfficer.SetCalculatedStats();
            securityOfficer.SetBaseSkills();
            securityOfficer.AddSkill(SkillAthletics, 10);
            securityOfficer.AddSkill(SkillAutofire, 12);
            securityOfficer.AddSkill(SkillBrawling, 10);
            securityOfficer.AddSkill(SkillConcentration, 7);
            securityOfficer.AddSkill(SkillConversation, 6);
            securityOfficer.AddSkill(SkillDeduction, 6);
            securityOfficer.AddSkill(SkillDriveLandVehicle, 12);
            securityOfficer.AddSkill(SkillEducation, 6);
            securityOfficer.AddSkill(SkillEvasion, 10);
            securityOfficer.AddSkill(SkillFirstAid, 6);
            securityOfficer.AddSkill(SkillHandgun, 10);
            securityOfficer.AddSkill(SkillHumanPerception, 6);
            securityOfficer.AddSkill(SkillInterrogation, 8);
            securityOfficer.AddSkill(SkillLanguage, 6, LanguageNative);
            securityOfficer.AddSkill(SkillLanguage, 6, LanguageStreetslang);
            securityOfficer.AddSkill(SkillLocalExpert, 6, LocalExpertYourHome);
            securityOfficer.AddSkill(SkillMeleeWeapon, 10);
            securityOfficer.AddSkill(SkillPerception, 6);
            securityOfficer.AddSkill(SkillPersuasion, 8);
            securityOfficer.AddSkill(SkillResistTortureDrugs, 10);
            securityOfficer.AddSkill(SkillShoulderArms, 10);
            securityOfficer.AddSkill(SkillStealth, 6);
            securityOfficer.AddSkill(SkillTactics, 8);
            securityOfficer.AddWeapon(WeaponTypeAssaultRifle, WeaponQualityStandard);
            securityOfficer.AddWeapon(WeaponTypeVeryHeavyPistol, WeaponQualityStandard);
            securityOfficer.AddWeapon(WeaponTypeMediumMelee, WeaponQualityStandard);
            securityOfficer.AddAmmo(AmmoTypeRifle, 50);
            securityOfficer.AddAmmo(AmmoTypeVeryHeavyPistol, 30);
            // TODO - Bulletproof shield SP / HP
            securityOfficer.AddGearSet(GearBinoculars, GearDisposableCellPhone, GearFlashlight, GearHandcuffs, GearHandcuffs, GearRadioCommunicator, GearRadioScannerMusicPlayer);
            securityOfficer.AddCyberwareSet(CyberwareNeuralLink, CyberwareKerenzikov);
            securityOfficer.InitializeNewCombatant();
            Combatants.Add(securityOfficer);
            #endregion
            #region Outrider
            Combatant outrider = new("Outrider", PortraitOutrider, ArmorTypeLightArmorjack);
            outrider.SetStats(6, 8, 8, 3, 5, 6, 0, 6, 6, 6);
            outrider.SetCalculatedStats();
            outrider.SetBaseSkills();
            outrider.AddSkill(SkillAnimalHandling, 8);
            outrider.AddSkill(SkillAthletics, 14);
            outrider.AddSkill(SkillAutofire, 12);
            outrider.AddSkill(SkillBasicTech, 5);
            outrider.AddSkill(SkillBrawling, 14);
            outrider.AddSkill(SkillConcentration, 10);
            outrider.AddSkill(SkillConversation, 6);
            outrider.AddSkill(SkillCriminology, 10);
            outrider.AddSkill(SkillDriveLandVehicle, 14);
            outrider.AddSkill(SkillEducation, 8);
            outrider.AddSkill(SkillEndurance, 10);
            outrider.AddSkill(SkillEvasion, 14);
            outrider.AddSkill(SkillFirstAid, 5);
            outrider.AddSkill(SkillHandgun, 14);
            outrider.AddSkill(SkillHumanPerception, 8);
            outrider.AddSkill(SkillLandVehicleTech, 7);
            outrider.AddSkill(SkillLanguage, 8, LanguageNative);
            outrider.AddSkill(SkillLanguage, 8, LanguageStreetslang);
            outrider.AddSkill(SkillLocalExpert, 8, LocalExpertBadlands);
            outrider.AddSkill(SkillLocalExpert, 8, LocalExpertYourHome);
            outrider.AddSkill(SkillMeleeWeapon, 12);
            outrider.AddSkill(SkillPerception, 14);
            outrider.AddSkill(SkillPersuasion, 7);
            outrider.AddSkill(SkillResistTortureDrugs, 12);
            outrider.AddSkill(SkillShoulderArms, 14);
            outrider.AddSkill(SkillStealth, 12);
            outrider.AddSkill(SkillStreetwise, 9);
            outrider.AddSkill(SkillTracking, 10);
            outrider.AddWeapon(WeaponTypeAssaultRifle, WeaponQualityStandard);
            outrider.AddWeapon(WeaponTypeVeryHeavyPistol, WeaponQualityStandard);
            outrider.AddWeapon(WeaponTypeLightMelee, WeaponQualityStandard);
            outrider.AddAmmo(AmmoTypeRifle, 60);
            outrider.AddAmmo(AmmoTypeVeryHeavyPistol, 40);
            outrider.AddGearSet(GearHandcuffs, GearHandcuffs, GearHomingTracer, GearRadioCommunicator);
            outrider.AddCyberwareSet(CyberwareCyberaudioSuite, CyberwareAmplifiedHearing, CyberwareCybereye, CyberwareTargetingScope, CyberwareTeleOptics, CyberwareNeuralLink, CyberwareInterfacePlugs);
            outrider.InitializeNewCombatant();
            Combatants.Add(outrider);
            #endregion
            #region Pyro
            Combatant pyro = new("Pyro", PortraitPyro, ArmorTypeLightArmorjack);
            pyro.SetStats(5, 8, 6, 7, 4, 4, 0, 6, 5, 3);
            pyro.SetCalculatedStats();
            pyro.SetBaseSkills();
            pyro.AddSkill(SkillAthletics, 11);
            pyro.AddSkill(SkillBasicTech, 12);
            pyro.AddSkill(SkillBrawling, 10);
            pyro.AddSkill(SkillConcentration, 8);
            pyro.AddSkill(SkillConversation, 5);
            pyro.AddSkill(SkillDemolitions, 13);
            pyro.AddSkill(SkillDriveLandVehicle, 10);
            pyro.AddSkill(SkillEducation, 7);
            pyro.AddSkill(SkillEvasion, 13);
            pyro.AddSkill(SkillFirstAid, 9);
            pyro.AddSkill(SkillHandgun, 14);
            pyro.AddSkill(SkillHeavyWeapons, 14);
            pyro.AddSkill(SkillHumanPerception, 5);
            pyro.AddSkill(SkillInterrogation, 10);
            pyro.AddSkill(SkillLanguage, 7, LanguageNative);
            pyro.AddSkill(SkillLanguage, 7, LanguageStreetslang);
            pyro.AddSkill(SkillLocalExpert, 7, LocalExpertYourHome);
            pyro.AddSkill(SkillMeleeWeapon, 13);
            pyro.AddSkill(SkillPerception, 12);
            pyro.AddSkill(SkillPersuasion, 6);
            pyro.AddSkill(SkillResistTortureDrugs, 14);
            pyro.AddSkill(SkillScience, 10, ScienceChemistry);
            pyro.AddSkill(SkillStealth, 10);
            pyro.AddSkill(SkillStreetwise, 8);
            pyro.AddSkill(SkillTactics, 8);
            pyro.AddWeapon(WeaponTypeFlamethrower, WeaponQualityStandard);
            pyro.AddWeapon(WeaponTypeHeavyPistol, WeaponQualityStandard);
            pyro.AddWeapon(WeaponTypeHeavyMelee, WeaponQualityStandard);
            pyro.AddAmmo(AmmoTypeIncendiaryShell, 8);
            pyro.AddAmmo(AmmoTypeVeryHeavyPistol, 50);
            // TODO - add consumable weapons (grenades)
            pyro.AddCyberwareSet(CyberwareCyberaudioSuite, CyberwareLevelDamper, CyberwareCybereye, CyberwareCybereye, CyberwareAntiDazzle, CyberwareAntiDazzle, CyberwareNasalFilters);
            pyro.InitializeNewCombatant();
            Combatants.Add(pyro);
            #endregion
            #region Cyberpsycho
            Combatant cyberpsycho = new("Cyberpsycho", PortraitCyberpsycho, ArmorTypeSubdermal);
            cyberpsycho.SetStats(5, 8, 8, 5, 4, 7, 0, 8, 10, 0);
            cyberpsycho.SetCalculatedStats();
            cyberpsycho.SetBaseSkills();
            cyberpsycho.AddSkill(SkillAthletics, 16);
            cyberpsycho.AddSkill(SkillAutofire, 14);
            cyberpsycho.AddSkill(SkillBasicTech, 11);
            cyberpsycho.AddSkill(SkillBrawling, 15);
            cyberpsycho.AddSkill(SkillConcentration, 6);
            cyberpsycho.AddSkill(SkillConversation, 2);
            cyberpsycho.AddSkill(SkillDriveLandVehicle, 10);
            cyberpsycho.AddSkill(SkillEducation, 7);
            cyberpsycho.AddSkill(SkillEndurance, 10);
            cyberpsycho.AddSkill(SkillEvasion, 13);
            cyberpsycho.AddSkill(SkillFirstAid, 6);
            cyberpsycho.AddSkill(SkillHandgun, 12);
            cyberpsycho.AddSkill(SkillHeavyWeapons, 14);
            cyberpsycho.AddSkill(SkillHumanPerception, 2);
            cyberpsycho.AddSkill(SkillInterrogation, 13);
            cyberpsycho.AddSkill(SkillLanguage, 7, LanguageNative);
            cyberpsycho.AddSkill(SkillLanguage, 7, LanguageStreetslang);
            cyberpsycho.AddSkill(SkillLocalExpert, 7, LocalExpertYourHome);
            cyberpsycho.AddSkill(SkillMeleeWeapon, 17);
            cyberpsycho.AddSkill(SkillPerception, 9);
            cyberpsycho.AddSkill(SkillPersuasion, 6);
            cyberpsycho.AddSkill(SkillResistTortureDrugs, 15);
            cyberpsycho.AddSkill(SkillStealth, 10);
            cyberpsycho.AddSkill(SkillTracking, 10);
            cyberpsycho.AddWeapon(WeaponTypePopupGrenadeLauncher, WeaponQualityStandard);
            cyberpsycho.AddWeapon(WeaponTypeHeavySmg, WeaponQualityStandard, "Popup Heavy SMG");
            cyberpsycho.AddWeapon(WeaponTypeVeryHeavyMelee, WeaponQualityStandard, "Cybersnake");
            cyberpsycho.AddWeapon(WeaponTypeHeavyMelee, WeaponQualityStandard, "Wolvers");
            cyberpsycho.AddAmmo(AmmoTypeGrenade, 2);
            cyberpsycho.AddAmmo(AmmoTypeHeavyPistol, 100);
            cyberpsycho.AddCyberwareSet(CyberwareCyberarm, CyberwareCyberarm, CyberwarePopupGrenadeLauncher, CyberwarePopupGrenadeLauncher,
                CyberwarePopupRangedWeapon, CyberwareWolvers, CyberwareCyberleg, CyberwareCyberleg, CyberwareJumpBooster, CyberwareCybersnake,
                CyberwareGraftedMuscleBoneLace, CyberwareNeuralLink, CyberwareChipwareSocket, CyberwarePainEditor, CyberwareSubdermalArmor);
            cyberpsycho.InitializeNewCombatant();
            Combatants.Add(cyberpsycho);
            #endregion
        }
        private static void PopulateCriticalInjuries()
        {
            AllCriticalInjuries = new();
            AllCriticalInjuries.AddRange(CriticalInjuriesToBody);
            AllCriticalInjuries.AddRange(CriticalInjuriesToHead);
        }
        private static void PopulateBlackIcePrograms()
        {
            // TODO - proper portraits for the Black ICE programs
            Combatant asp = new("Asp", PortraitNetrunner);
            asp.SetBlackIceStats(AntiPersonnelBlackIce, 4, 6, 2, 2, 15, "Destroys a single Program installed on the enemy Netrunner's Cyberdeck at random.");
            BlackIcePrograms.Add(asp);

            Combatant giant = new("Giant", PortraitNetrunner);
            giant.SetBlackIceStats(AntiPersonnelBlackIce, 2, 2, 8, 4, 25, "Does 3d6 damage direct to an enemy Netrunner's brain. The Netrunner is forcibly and unsafely Jacked Out of their current Netrun. They suffer the effect of all Rezzed enemy Black ICE they've encountered in the Architecture as they leave, not including the Giant.");
            BlackIcePrograms.Add(giant);

            Combatant hellhound = new("Hellhound", PortraitNetrunner);
            hellhound.SetBlackIceStats(AntiPersonnelBlackIce, 6, 6, 6, 2, 20, "Does 2d6 damage direct to the Netrunner's brain. Unless insulated, their Cyberdeck catches fire along with their clothing. Until they spend a Meat Action to put themselves out, they take 2 damage to their HP whenever they end their Turn. Multiple instances of this effect cannot stack.");
            BlackIcePrograms.Add(hellhound);

            Combatant kraken = new("Kraken", PortraitNetrunner);
            kraken.SetBlackIceStats(AntiPersonnelBlackIce, 6, 2, 8, 4, 30, "Does 3d6 damage direct to an enemy Netrunner's brain. Until the end of the Netrunner's next Turn, the Netrunner cannot progress deeper into the Architecture or Jack Out safely (The Netrunner can still perform an unsafe Jack Out).");
            BlackIcePrograms.Add(kraken);

            Combatant liche = new("Liche", PortraitNetrunner);
            liche.SetBlackIceStats(AntiPersonnelBlackIce, 8, 2, 6, 2, 25, "Enemy Netrunner's INT, REF, and DEX are each lowered by 1d6 for the next hour (minimum 1). The effects are largely psychosomatic and leave no permanent effects.");
            BlackIcePrograms.Add(liche);

            Combatant raven = new("Raven", PortraitNetrunner);
            raven.SetBlackIceStats(AntiPersonnelBlackIce, 6, 4, 4, 2, 15, "Derezzes a single Defender Program the enemy Netrunner has Rezzed at random, then deals 1d6 damage direct to the Netrunner's brain.");
            BlackIcePrograms.Add(raven);

            Combatant scorpion = new("Scorpion", PortraitNetrunner);
            scorpion.SetBlackIceStats(AntiPersonnelBlackIce, 2, 6, 2, 2, 15, "Enemy Netrunner's MOVE is lowered by 1d6 for the next hour (minimum 1). The effects are largely psychosomatic and leave no permanent effects.");
            BlackIcePrograms.Add(scorpion);

            Combatant skunk = new("Skunk", PortraitNetrunner);
            skunk.SetBlackIceStats(AntiPersonnelBlackIce, 2, 4, 4, 2, 10, "Until this Program is Derezzed, an enemy Netrunner hit by this Effect makes all Slide Checks at a -2. Each Skunk Black ICE can only affect a single Netrunner at a time, but the effects of multiple Skunks can stack.");
            BlackIcePrograms.Add(skunk);

            Combatant wisp = new("Wisp", PortraitNetrunner);
            wisp.SetBlackIceStats(AntiPersonnelBlackIce, 4, 4, 4, 2, 15, "Does 1d6 damage direct to the enemy Netrunner's brain and lowers the amount of total NET Actions the Netrunner can accomplish on their next Turn by 1 (minimum 2).");
            BlackIcePrograms.Add(wisp);

            Combatant dragon = new("Dragon", PortraitNetrunner);
            dragon.SetBlackIceStats(AntiProgramBlackIce, 6, 4, 6, 6, 30, "Deals 6d6 damage to a Program. If this damage would be enough to Derezz the Program, it is instead Destroyed.");
            BlackIcePrograms.Add(dragon);

            Combatant killer = new("Killer", PortraitNetrunner);
            killer.SetBlackIceStats(AntiProgramBlackIce, 4, 8, 6, 2, 20, "Deals 4d6 damage to a Program. If this damage would be enough to Derezz the Program, it is instead Destroyed.");
            BlackIcePrograms.Add(killer);

            Combatant sabertooth = new("Sabertooth", PortraitNetrunner);
            sabertooth.SetBlackIceStats(AntiProgramBlackIce, 8, 6, 6, 2, 25, "Deals 6d6 damage to a Program. If this damage would be enough to Derezz the Program, it is instead Destroyed.");
            BlackIcePrograms.Add(sabertooth);

        }
        private static void PopulateDemons()
        {
            // TODO - proper Demon portraits
            Combatant imp = new("Imp", PortraitNetrunner);
            imp.SetDemonStats(15, 3, 2, 14);
            Demons.Add(imp);

            Combatant efreet = new("Efreet", PortraitAssassin);
            efreet.SetDemonStats(25, 3, 2, 14);
            Demons.Add(efreet);

            Combatant balron = new("Balron", PortraitBodyguard);
            balron.SetDemonStats(30, 7, 4, 14);
            Demons.Add(balron);

        }
        private static void PopulateActiveDefenses()
        {
            // TODO - portraits
            Combatant airSwarm = new("Air Swarm Drone Cloud", PortraitNetrunner);
            airSwarm.SetActiveDefenseStats(8, 15, 17);
            airSwarm.AddWeapon(WeaponTypeVeryHeavyMelee, WeaponQualityStandard);
            ActiveDefenses.Add(airSwarm);

            Combatant groundDrone = new("Ground Drone", PortraitNetrunner);
            groundDrone.SetActiveDefenseStats(4, 30, 21);
            groundDrone.AddWeapon(WeaponTypeVeryHeavyPistol, WeaponQualityStandard);
            groundDrone.AddWeapon(WeaponTypeSmg, WeaponQualityStandard);
            groundDrone.AddAmmo(AmmoTypeVeryHeavyPistol, 8); // TODO - ammo variants
            groundDrone.AddAmmo(AmmoTypeMediumPistol, 30);
            ActiveDefenses.Add(groundDrone);

            Combatant largeAirDrone = new("Large Air Drone", PortraitNetrunner);
            largeAirDrone.SetActiveDefenseStats(6, 20, 21);
            largeAirDrone.AddWeapon(WeaponTypeDartgun, WeaponQualityStandard);
            largeAirDrone.AddWeapon(WeaponTypeVeryHeavyPistol, WeaponQualityStandard);
            largeAirDrone.AddAmmo(AmmoTypeDart, 8);
            largeAirDrone.AddAmmo(AmmoTypeVeryHeavyPistol, 8);
            ActiveDefenses.Add(largeAirDrone);

            Combatant miniAirDrone = new("Mini Air Drone", PortraitNetrunner);
            miniAirDrone.SetActiveDefenseStats(6, 15, 17);
            miniAirDrone.AddWeapon(WeaponTypeDartgun, WeaponQualityStandard);
            miniAirDrone.AddWeapon(WeaponTypeVeryHeavyPistol, WeaponQualityStandard);
            miniAirDrone.AddAmmo(AmmoTypeDart, 8);
            miniAirDrone.AddAmmo(AmmoTypeVeryHeavyPistol, 8);
            ActiveDefenses.Add(miniAirDrone);

            Combatant spiderDrone = new("Spider Walking Drone", PortraitNetrunner);
            spiderDrone.SetActiveDefenseStats(4, 40, 21);
            spiderDrone.AddWeapon(WeaponTypeGrenadeLauncher, WeaponQualityStandard);
            spiderDrone.AddWeapon(WeaponTypeVeryHeavyMelee, WeaponQualityStandard);
            spiderDrone.AddWeapon(WeaponTypeHeavySmg, WeaponQualityStandard);
            spiderDrone.AddAmmo(AmmoTypeGrenade, 2); // TODO - teargas grenades lol, no need to have office security destroying whole cubicles
            spiderDrone.AddAmmo(AmmoTypeHeavyPistol, 40);

        }
        private static void PopulateEmplacedDefenses()
        {
            Combatant bloodSwarm = new("Automated Blood Swarm", PortraitNetrunner);
            bloodSwarm.SetEmplacedDefenseStats(0, 1, 21, "Automated weapon disperses a swarm of nanites into the room as a red fog. The nanites, when inhaled, attack their victim from within by binding the hemoglobin in their blood into clots. Anything that filters gas attacks blocks the Automated Blood Swarm.\nEveryone Meat within the Defended Area must succeed at a DV15 Resist Torture/ Drugs Check. Anyone who fails is dealt 3d6 damage directly to their HP. Their armor isn't ablated.");
            EmplacedDefenses.Add(bloodSwarm);

            Combatant melee = new("Automated Melee Weapon", PortraitNetrunner);
            melee.SetEmplacedDefenseStats(14, 25, 17);
            melee.AddWeapon(WeaponTypeVeryHeavyMelee, WeaponQualityStandard);
            EmplacedDefenses.Add(melee);

            Combatant turret = new("Automated Turret", PortraitNetrunner);
            turret.SetEmplacedDefenseStats(14, 25, 17);
            turret.AddWeapon(WeaponTypeAssaultRifle, WeaponQualityStandard);
            turret.AddWeapon(WeaponTypeFlamethrower, WeaponQualityStandard);
            turret.AddWeapon(WeaponTypeDartgun, WeaponQualityStandard);
            turret.AddWeapon(WeaponTypeVeryHeavyPistol, WeaponQualityStandard);
            turret.AddWeapon(WeaponTypeHeavySmg, WeaponQualityStandard);
            turret.AddAmmo(AmmoTypeRifle, 25);
            turret.AddAmmo(AmmoTypeIncendiaryShell, 4);
            turret.AddAmmo(AmmoTypeDart, 8);
            turret.AddAmmo(AmmoTypeVeryHeavyPistol, 8); // armor piercing
            turret.AddAmmo(AmmoTypeHeavyPistol, 40);
            EmplacedDefenses.Add(turret);

        }


    }
}
