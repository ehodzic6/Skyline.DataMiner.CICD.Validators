namespace ProtocolTests.Protocol.Params.Param.Display.Decimals.CheckDecimalsTag
{
    using System;
    using System.Collections.Generic;

    using FluentAssertions;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    using Skyline.DataMiner.CICD.Validators.Common.Interfaces;
    using Skyline.DataMiner.CICD.Validators.Common.Model;
    using Skyline.DataMiner.CICD.Validators.Protocol.Common;
    using Skyline.DataMiner.CICD.Validators.Protocol.Interfaces;
    using Skyline.DataMiner.CICD.Validators.Protocol.Tests.Protocol.Params.Param.Display.Decimals.CheckDecimalsTag;

    [TestClass]
    public class Validate
    {
        private readonly IValidate check = new CheckDecimalsTag();

        #region Valid Checks

        [TestMethod]

        public void Param_CheckDecimalsTag_Valid()
        {
            Generic.ValidateData data = new Generic.ValidateData
            {
                TestType = Generic.TestType.Valid,
                FileName = "Valid",
                ExpectedResults = new List<IValidationResult>()
            };

            Generic.Validate(check, data);
        }

        #endregion

        #region Invalid Checks

        [TestMethod]

        public void Param_CheckDecimalsTag_InvalidTagForTime()
        {
            Generic.ValidateData data = new Generic.ValidateData
            {
                TestType = Generic.TestType.Invalid,
                FileName = "InvalidTagForTime",
                ExpectedResults = new List<IValidationResult>
                {
                    Error.InvalidTagForTime(null, null, null),
                }
            };

            Generic.Validate(check, data);
        }

        #endregion
    }

    [TestClass]
    public class ErrorMessages
    {
        [TestMethod]

        public void Param_CheckDecimalsTag_InvalidTagForTime()
        {
            // Create ErrorMessage
            var message = Error.InvalidTagForTime(null, null, null);

            var expected = new ValidationResult
            {
                Severity = Severity.Major,
                Certainty = Certainty.Certain,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = "Unsupported tag 'Display/Decimals'.",
                Details = "Parameters containing time values must have no decimals to be correct.",
                HasCodeFix = false,
            };

            // Assert
            message.Should().BeEquivalentTo(expected, Generic.ExcludePropertiesForErrorMessages);
        }
    }

    [TestClass]
    [Ignore]

    public class Attribute
    {
        private readonly IRoot check = new CheckDecimalsTag();

        [TestMethod]
        public void Param_CheckDecimalsTag_CheckCategory() => Generic.CheckCategory(check, Category.Param);

        [TestMethod]
        public void Param_CheckDecimalsTag_CheckId() => Generic.CheckId(check, CheckId.CheckDecimalsTag);
    }
}