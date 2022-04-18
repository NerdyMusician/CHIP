using CyberpunkGameplayAssistant.Models;
using System;
using System.Collections.Generic;

namespace CyberpunkGameplayAssistant.Toolbox
{
    public static class ReferenceData
    {
        // Utility
        public static Random RNG = new();

        // File Locations
        public const string LogFile = "log.txt";

        // Message Types
        public const string MessageTypeCombat = "Combat";

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


    }
}
