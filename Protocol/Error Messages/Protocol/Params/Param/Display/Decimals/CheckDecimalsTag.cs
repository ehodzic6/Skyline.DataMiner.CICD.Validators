// <auto-generated>This is auto-generated code by Validator Management Tool. Do not modify.</auto-generated>
namespace Skyline.DataMiner.CICD.Validators.Protocol.Tests.Protocol.Params.Param.Display.Decimals.CheckDecimalsTag
{
    using System;
    using System.Collections.Generic;

    using Skyline.DataMiner.CICD.Models.Protocol.Read;
    using Skyline.DataMiner.CICD.Validators.Common.Interfaces;
    using Skyline.DataMiner.CICD.Validators.Common.Model;
    using Skyline.DataMiner.CICD.Validators.Protocol.Common;
    using Skyline.DataMiner.CICD.Validators.Protocol.Interfaces;

    internal static class Error
    {
        public static IValidationResult InvalidTagForTime(IValidate test, IReadable referenceNode, IReadable positionNode)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckDecimalsTag,
                ErrorId = ErrorIds.InvalidTagForTime,
                FullId = "2.76.1",
                Category = Category.Param,
                Severity = Severity.Major,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Unsupported tag '{0}'.", "Display/Decimals"),
                HowToFix = "Delete a Protocol/Params/Param/Display/Decimal tag",
                ExampleCode = "<Display>" + Environment.NewLine + "   <RTDisplay>true</RTDisplay>" + Environment.NewLine + "</Display>" + Environment.NewLine + "<Measurement>" + Environment.NewLine + "   <Type options=\"time\">number</Type>" + Environment.NewLine + "</Measurement>" + Environment.NewLine + "",
                Details = "Parameters containing time values must have no decimals to be correct.",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }
    }

    internal static class ErrorIds
    {
        public const uint InvalidTagForTime = 1;
    }

    /// <summary>
    /// Contains the identifiers of the checks.
    /// </summary>
    public static class CheckId
    {
        /// <summary>
        /// The check identifier.
        /// </summary>
        public const uint CheckDecimalsTag = 76;
    }
}