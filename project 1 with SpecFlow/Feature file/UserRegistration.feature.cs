﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:2.3.2.0
//      SpecFlow Generator Version:2.3.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace project_1_with_SpecFlow.FeatureFile
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.3.2.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("UserRegistration")]
    public partial class UserRegistrationFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "UserRegistration.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "UserRegistration", "\tIn order to use the website\'s services\r\n\tAs a visitor\r\n\tI want to be able to reg" +
                    "ister an account ", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.OneTimeTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [NUnit.Framework.SetUpAttribute()]
        public virtual void TestInitialize()
        {
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Enter blank registration information")]
        [NUnit.Framework.CategoryAttribute("invalidTest_Blankinfo")]
        public virtual void EnterBlankRegistrationInformation()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Enter blank registration information", new string[] {
                        "invalidTest_Blankinfo"});
#line 7
this.ScenarioSetup(scenarioInfo);
#line 8
 testRunner.Given("I am on the registration page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 9
 testRunner.And("I have entered blank information", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 10
 testRunner.When("I press register", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 11
 testRunner.Then("the error message caused by blank input should be shown on the screen", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Enter invalid email")]
        [NUnit.Framework.CategoryAttribute("invalidTest_Email")]
        [NUnit.Framework.TestCaseAttribute("信123sd@yahoo.com", null)]
        [NUnit.Framework.TestCaseAttribute("1", null)]
        [NUnit.Framework.TestCaseAttribute("aasdasd  asd@yahoo.com", null)]
        public virtual void EnterInvalidEmail(string invalidEmail, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "invalidTest_Email"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Enter invalid email", @__tags);
#line 14
this.ScenarioSetup(scenarioInfo);
#line 15
 testRunner.Given("I am on the registration page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 16
 testRunner.And(string.Format("I have entered \"{0}\" invalid email", invalidEmail), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 17
 testRunner.When("I press register", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 18
 testRunner.Then("the error message caused by invalid email should be shown on the screen", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Enter invalid text input username")]
        [NUnit.Framework.CategoryAttribute("invalidTest_Username")]
        [NUnit.Framework.TestCaseAttribute("@@@@@@@@@@@", null)]
        [NUnit.Framework.TestCaseAttribute("%%%%%%%%%", null)]
        [NUnit.Framework.TestCaseAttribute("0       1", null)]
        public virtual void EnterInvalidTextInputUsername(string invalidUsername, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "invalidTest_Username"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Enter invalid text input username", @__tags);
#line 27
this.ScenarioSetup(scenarioInfo);
#line 28
 testRunner.Given("I am on the registration page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 29
 testRunner.And(string.Format("I have entered \"{0}\" invalid text input username", invalidUsername), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 30
 testRunner.When("I press register", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 31
 testRunner.Then("the error message caused by invalid text input username should be shown on the sc" +
                    "reen", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Enter too short username")]
        [NUnit.Framework.CategoryAttribute("invalidTest_Username")]
        [NUnit.Framework.TestCaseAttribute("111", null)]
        [NUnit.Framework.TestCaseAttribute("信", null)]
        [NUnit.Framework.TestCaseAttribute("、", null)]
        [NUnit.Framework.TestCaseAttribute("_", null)]
        public virtual void EnterTooShortUsername(string invalidUsername, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "invalidTest_Username"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Enter too short username", @__tags);
#line 40
this.ScenarioSetup(scenarioInfo);
#line 41
 testRunner.Given("I am on the registration page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 42
 testRunner.And(string.Format("I have entered \"{0}\" too short username", invalidUsername), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 43
 testRunner.When("I press register", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 44
 testRunner.Then("the error message caused by too short username should be shown on the screen", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Enter too long username")]
        [NUnit.Framework.CategoryAttribute("invalidTest_Username")]
        [NUnit.Framework.TestCaseAttribute("1234567891234567891", null)]
        [NUnit.Framework.TestCaseAttribute("信信信信信信信信信信", null)]
        [NUnit.Framework.TestCaseAttribute("、、、、、、、、、、", null)]
        [NUnit.Framework.TestCaseAttribute("___________________", null)]
        public virtual void EnterTooLongUsername(string invalidUsername, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "invalidTest_Username"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Enter too long username", @__tags);
#line 54
this.ScenarioSetup(scenarioInfo);
#line 55
 testRunner.Given("I am on the registration page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 56
 testRunner.And(string.Format("I have entered \"{0}\" too long username", invalidUsername), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 57
 testRunner.When("I press register", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 58
 testRunner.Then("the error message caused by too long username should be shown on the screen", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Enter too short password")]
        [NUnit.Framework.CategoryAttribute("invalidTest_Password")]
        [NUnit.Framework.TestCaseAttribute("1234", null)]
        [NUnit.Framework.TestCaseAttribute("信信信信", null)]
        [NUnit.Framework.TestCaseAttribute("、、、、", null)]
        [NUnit.Framework.TestCaseAttribute("____", null)]
        [NUnit.Framework.TestCaseAttribute("1  1", null)]
        public virtual void EnterTooShortPassword(string invalidPassword, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "invalidTest_Password"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Enter too short password", @__tags);
#line 68
this.ScenarioSetup(scenarioInfo);
#line 69
 testRunner.Given("I am on the registration page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 70
 testRunner.And(string.Format("I have entered \"{0}\" too short password", invalidPassword), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 71
 testRunner.When("I press register", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 72
 testRunner.Then("最少需要输入 5 个字符 should be shown on the screen", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Enter too long password")]
        [NUnit.Framework.CategoryAttribute("invalidTest_Password")]
        [NUnit.Framework.TestCaseAttribute("123456789123456789123", null)]
        [NUnit.Framework.TestCaseAttribute("信信信信信信信信信信信信信信信信信信信信信", null)]
        [NUnit.Framework.TestCaseAttribute("、、、、、、、、、、、、、、、、、、、、、", null)]
        [NUnit.Framework.TestCaseAttribute("_____________________", null)]
        [NUnit.Framework.TestCaseAttribute("1                   1", null)]
        public virtual void EnterTooLongPassword(string invalidPassword, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "invalidTest_Password"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Enter too long password", @__tags);
#line 83
this.ScenarioSetup(scenarioInfo);
#line 84
 testRunner.Given("I am on the registration page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 85
 testRunner.And(string.Format("I have entered \"{0}\" too long password", invalidPassword), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 86
 testRunner.When("I press register", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 87
 testRunner.Then("最多只能输入 20 个字符 should be shown on the screen", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Enter invalid text type captcha")]
        [NUnit.Framework.CategoryAttribute("invalidTest_Captcha")]
        [NUnit.Framework.TestCaseAttribute("信信信信", null)]
        [NUnit.Framework.TestCaseAttribute("、、、、", null)]
        [NUnit.Framework.TestCaseAttribute("1   1", null)]
        public virtual void EnterInvalidTextTypeCaptcha(string invalidCaptcha, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "invalidTest_Captcha"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Enter invalid text type captcha", @__tags);
#line 98
this.ScenarioSetup(scenarioInfo);
#line 99
 testRunner.Given("I am on the registration page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 100
 testRunner.And(string.Format("I have entered \"{0}\" invalid text type capcha", invalidCaptcha), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 101
 testRunner.When("I press register", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 102
 testRunner.Then("必须是英文字母、数字及下划线组成 should be shown on the screen", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Enter incorrect captcha")]
        [NUnit.Framework.CategoryAttribute("invalidTest_Captcha")]
        [NUnit.Framework.TestCaseAttribute("12345", null)]
        [NUnit.Framework.TestCaseAttribute("abcde", null)]
        public virtual void EnterIncorrectCaptcha(string invalidCaptcha, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "invalidTest_Captcha"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Enter incorrect captcha", @__tags);
#line 111
this.ScenarioSetup(scenarioInfo);
#line 112
 testRunner.Given("I am on the registration page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 113
 testRunner.And(string.Format("I have entered \"{0}\" incorrect capcha", invalidCaptcha), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 114
 testRunner.When("I press register", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 115
 testRunner.Then("验证码错误 should be shown on the screen", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
