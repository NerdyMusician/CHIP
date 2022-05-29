using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;
using System.Windows.Markup;

namespace CyberpunkGameplayAssistant.Toolbox
{
    public class ImageBasedOnMessageType : ConverterMarkupExtension<ImageBasedOnMessageType>
    {
        public ImageBasedOnMessageType()
        {

        }

        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            string iconName = value switch
            {
                ReferenceData.MessageInitiative => "Icon_Runner",
                ReferenceData.MessageCoinFllip => "Icon_SilverCoin",
                ReferenceData.MessageGmRoll => "Icon_Dice",
                ReferenceData.MessageLoot => "Icon_Pack",
                ReferenceData.MessageReload => "Icon_Reload",
                ReferenceData.MessageSkillCheck => "Icon_Hand",
                ReferenceData.MessageStandardAction => "Icon_Action",
                ReferenceData.MessageStatCheck => "Icon_Hex_A",
                ReferenceData.MessageWeaponAttack => "Icon_Reticle",
                _ => "Icon_Rpg_Note"
            };
            return ReferenceData.Framework.FindResource(iconName) as Style;
        }
    }
    public class ImageBasedOnStat : ConverterMarkupExtension<ImageBasedOnStat>
    {
        public ImageBasedOnStat()
        {

        }

        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            string iconName = value switch
            {
                "Ability Check" => "Icon_Hex_A",
                "Attack" => "Icon_Crossed_Swords",
                "Coin Flip" => "Icon_CopperCoin",
                "DM Roll" => "Icon_Dice",
                "Fall Damage" => "Icon_Fall",
                "Initiative" => "Icon_Initiative",
                "Loot" => "Icon_Pack",
                "Rest" => "Icon_Sleep",
                "Saving Throw" => "Icon_Letter_S",
                "Skill Check" => "Icon_Hand",
                "Spell" => "Icon_Rpg_Staff",
                "Weather Change" => "Icon_Weather_PartlyCloudy",
                _ => "Icon_Rpg_Note"
            };
            return ReferenceData.Framework.FindResource(iconName) as Style;
        }
    }
    public class ImageBasedOnSkill : ConverterMarkupExtension<ImageBasedOnSkill>
    {
        public ImageBasedOnSkill()
        {

        }

        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            string iconName = value switch
            {
                "Ability Check" => "Icon_Hex_A",
                "Attack" => "Icon_Crossed_Swords",
                "Coin Flip" => "Icon_CopperCoin",
                "DM Roll" => "Icon_Dice",
                "Fall Damage" => "Icon_Fall",
                "Initiative" => "Icon_Initiative",
                "Loot" => "Icon_Pack",
                "Rest" => "Icon_Sleep",
                "Saving Throw" => "Icon_Letter_S",
                "Skill Check" => "Icon_Hand",
                "Spell" => "Icon_Rpg_Staff",
                "Weather Change" => "Icon_Weather_PartlyCloudy",
                _ => "Icon_Rpg_Note"
            };
            return ReferenceData.Framework.FindResource(iconName) as Style;
        }
    }
    public class ImageBasedOnAction : ConverterMarkupExtension<ImageBasedOnAction>
    {
        public ImageBasedOnAction()
        {

        }
        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            string iconName = value switch
            {
                // Standard Actions
                ReferenceData.ActionBrawl => "Icon_Fist",
                ReferenceData.ActionChoke => "Icon_Fist",
                ReferenceData.ActionDeathSave => "Icon_Skull",
                ReferenceData.ActionEvade => "Icon_Dodge",
                ReferenceData.ActionGrab => "Icon_Fist",
                ReferenceData.ActionInitiative => "Icon_Runner",
                ReferenceData.ActionThrowGrapple => "Icon_Fist",
                ReferenceData.ActionThrowObject => "Icon_Throw",

                // NET Actions
                ReferenceData.NetActionInterface => "Icon_Network",
                ReferenceData.NetActionJackIn => "Icon_Connected",
                ReferenceData.NetActionJackOut => "Icon_Disconnected",
                ReferenceData.NetActionActivateProgram => "Icon_Program",
                ReferenceData.NetActionScanner => "Icon_Radar",
                ReferenceData.NetActionBackdoor => "Icon_Network",
                ReferenceData.NetActionCloak => "Icon_Network",
                ReferenceData.NetActionControl => "Icon_Network",
                ReferenceData.NetActionEyeDee => "Icon_Network",
                ReferenceData.NetActionPathfinder => "Icon_Search",
                ReferenceData.NetActionSlide => "Icon_Dodge",
                ReferenceData.NetActionVirus => "Icon_Network",
                ReferenceData.NetActionZap => "Icon_Zap",

                // Default
                _ => "Icon_Rpg_Note"
            };
            return ReferenceData.Framework.FindResource(iconName) as Style;
        }
    }
    public class ImageBasedOnCombatantType : ConverterMarkupExtension<ImageBasedOnCombatantType>
    {
        public ImageBasedOnCombatantType()
        {

        }
        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            string iconName = value switch
            {
                ReferenceData.ActiveDefense => "Icon_Turret",
                ReferenceData.BlackIce => "Icon_Program",
                ReferenceData.Demon => "Icon_Program",
                ReferenceData.EmplacedDefense => "Icon_Turret",
                ReferenceData.ExecTeamMember => "Icon_Briefcase",
                ReferenceData.LawmanBackup => "Icon_Badge",
                ReferenceData.TraumaTeam => "Icon_Medical",
                _ => "Icon_Fist"
            };
            return ReferenceData.Framework.FindResource(iconName) as Style;
        }
    }
}
