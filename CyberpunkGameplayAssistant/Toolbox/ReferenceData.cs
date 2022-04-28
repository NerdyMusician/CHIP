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
        public static MainViewModel MainModelRef;
        public static FrameworkElement Framework = new();
        public static Random RNG = new();
        public static readonly string[] Alphabet = { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };

        // Other
        public static readonly DateTime DefaultDate = new(2045, 1, 1);
        public const string ShortDateFormat = "yyyy.MM.dd hh:mm";
        public const string LongDateFormat = "D";

        // File Locations
        public const string File_Log = "log.txt";
        public static readonly string File_CampaignData = $"{Environment.CurrentDirectory}/Data/Campaigns.xml";

        // Directories
        public static readonly string CombatantImageDirectory = $"{Environment.CurrentDirectory}/Resources/Combatants/";

        // MultiObject Select Modes
        public const string MultiModeEnemies = "Enemies";

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

        // Message Types
        public const string MessageTypeCombat = "Combat";
        public const string MessageTypeSkillCheck = "Skill Check";

        // Wound States
        public const string WoundStateUnharmed = "Unharmed";
        public const string WoundStateLightlyWounded = "Lightly Wounded";
        public const string WoundStateSeriouslyWounded = "Seriously Wounded";
        public const string WoundStateMortallyWounded = "Mortally Wounded";
        public const string WoundStateDead = "Dead";

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

        // Stats
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
        public const string SkillMartialArts = "MartialArts";
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

        public static readonly List<Armor> ArmorTable = new()
        {
            new(ArmorTypeLeather, 4, 0),
            new(ArmorTypeKevlar, 7, 0),
            new(ArmorTypeLightArmorjack, 11, 0),
            new(ArmorTypeBodyweightSuit, 11, 0),
            new(ArmorTypeMediumArmorjack, 12, -2),
            new(ArmorTypeHeavyArmorjack, 13, -2),
            new(ArmorTypeFlak, 15, -4),
            new(ArmorTypeMetalgear, 18, -4)
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
            new(WeaponTypeAssaultRifle, 25, 35, 45),
            new(WeaponTypeSniperRifle, 4, 8, 12),
            new(WeaponTypeGrenadeLauncher, 2, 4, 6),
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
            new(WeaponTypeRocketLauncher, SkillHeavyWeapons, 8, 2, AmmoTypeRocket, 1, false, WeaponCostTierHigh)
        };
        public static readonly Dictionary<string, int> AutofireTable = new()
        {
            { WeaponTypeSmg, 3 },
            { WeaponTypeHeavySmg, 3 },
            { WeaponTypeAssaultRifle, 4 }
        };

        public static readonly List<MarketWeapon> WeaponMarket = new()
        {
            // Melee Weapons
            new("Combat Knife", WeaponTypeLightMelee, WeaponQualityStandard),
            new("Tomahawk", WeaponTypeLightMelee, WeaponQualityStandard),
            new("Baseball Bat", WeaponTypeMediumMelee, WeaponQualityStandard),
            new("Crowbar", WeaponTypeMediumMelee, WeaponQualityStandard),
            new("Machete", WeaponTypeMediumMelee, WeaponQualityStandard),
            new("Lead Pipe", WeaponTypeHeavyMelee, WeaponQualityStandard),
            new("Sword", WeaponTypeHeavyMelee, WeaponQualityStandard),
            new("Spiked Bat", WeaponTypeHeavyMelee, WeaponQualityStandard),
            new("Chainsaw", WeaponTypeVeryHeavyMelee, WeaponQualityStandard),
            new("Sledgehammer", WeaponTypeVeryHeavyMelee, WeaponQualityStandard),
            new("Helicopter Blade", WeaponTypeVeryHeavyMelee, WeaponQualityStandard),
            new("Naginata", WeaponTypeVeryHeavyMelee, WeaponQualityStandard),

            // Poor Quality Weapons
            new($"{CorpoDaiLung} Streetmaster", WeaponTypeMediumPistol, WeaponQualityPoor),
            new($"{CorpoDaiLung} Magnum", WeaponTypeHeavyPistol, WeaponQualityPoor),
            new($"{CorpoFederatedArms} Super Chief", WeaponTypeVeryHeavyPistol, WeaponQualityPoor),
            new($"{CorpoGunMart} Sherwood", WeaponTypeBowsAndCrossbows, WeaponQualityPoor),
            new($"{CorpoGunMart} Hunter", WeaponTypeBowsAndCrossbows, WeaponQualityPoor),
            new($"{CorpoFederatedArms} Tech-Assault III", WeaponTypeSmg, WeaponQualityPoor),
            new($"{CorpoChadranArms} City Reaper", WeaponTypeHeavySmg, WeaponQualityPoor),
            new($"{CorpoGunMart} Home Defender", WeaponTypeShotgun, WeaponQualityPoor),
            new($"{CorpoChadranArms} Jungle Reaper", WeaponTypeAssaultRifle, WeaponQualityPoor),
            new($"{CorpoGunMart} Snipe-Star", WeaponTypeSniperRifle, WeaponQualityPoor),
            new($"{CorpoTowaManufacturing} Type-G", WeaponTypeGrenadeLauncher, WeaponQualityPoor),
            new($"{CorpoTowaManufacturing} Type-R", WeaponTypeRocketLauncher, WeaponQualityPoor),

            // Standard Quality Weapons
            new($"{CorpoFederatedArms} X-9mm", WeaponTypeMediumPistol, WeaponQualityStandard), // TODO

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
        #endregion

        public static List<Combatant> Combatants = new()
        {

        };

        // Public Methods
        public static void PopulateData()
        {
            PopulateCombatants();
        }
        public static void PopulateCombatants()
        {
            #region Bodyguard
            Combatant bodyguard = new("Bodyguard", PortraitBodyguard, ArmorTypeKevlar);
            bodyguard.SetStoppingPower();
            bodyguard.SetStats(3, 6, 5, 2, 4, 4, 0, 4, 6, 3);
            bodyguard.SetDerivedStats();
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
            bodyguard.OrganizeSkillsToCategories();
            bodyguard.AddWeapon(WeaponTypeShotgun, WeaponQualityPoor);
            bodyguard.AddWeapon(WeaponTypeVeryHeavyPistol, WeaponQualityStandard);
            bodyguard.AddAmmo(AmmoTypeSlug, 25);
            bodyguard.AddAmmo(AmmoTypeVeryHeavyPistol, 25);
            bodyguard.AddGearSet(GearRadioCommunicator);
            bodyguard.ReloadAllWeapons();
            Combatants.Add(bodyguard);
            #endregion

        }

    }
}
