﻿/*
 * Created by Ranorex
 * User: User
 * Date: 09.10.2015
 * Time: 13:04
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Threading;
using WinForms = System.Windows.Forms;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Testing;

namespace TestGitIntegration1
{
    /// <summary>
    /// Description of UserCodeModule1.
    /// </summary>
    [TestModule("C1756870-DC04-451B-BFC4-FDBD1DDE7508", ModuleType.UserCode, 1)]
    public class UserCodeModule1 : ITestModule
    {
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public UserCodeModule1()
        {
            // Do not delete - a parameterless constructor is required!
        }

        /// <summary>
        /// Performs the playback of actions in this module.
        /// </summary>
        /// <remarks>You should not call this method directly, instead pass the module
        /// instance to the <see cref="TestModuleRunner.Run(ITestModule)"/> method
        /// that will in turn invoke this method.</remarks>
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 100;
            Delay.SpeedFactor = 1.0;
        }
    }
}
