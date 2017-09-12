﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// DO NOT MODIFY THIS FILE! It is regenerated by the designer.
// All your modifications will be lost!
// http://www.ranorex.com
//
///////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Repository;
using Ranorex.Core.Testing;

namespace TestGitIntegration1
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    /// The class representing the TestGitIntegration1Repository element repository.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", "7.1")]
    [RepositoryFolder("331c7386-f98b-4f51-bb26-d5a0c8db9de0")]
    public partial class TestGitIntegration1Repository : RepoGenBaseFolder
    {
        static TestGitIntegration1Repository instance = new TestGitIntegration1Repository();
        TestGitIntegration1RepositoryFolders.Explorer123AppFolder _explorer123;

        /// <summary>
        /// Gets the singleton class instance representing the TestGitIntegration1Repository element repository.
        /// </summary>
        [RepositoryFolder("331c7386-f98b-4f51-bb26-d5a0c8db9de0")]
        public static TestGitIntegration1Repository Instance
        {
            get { return instance; }
        }

        /// <summary>
        /// Repository class constructor.
        /// </summary>
        public TestGitIntegration1Repository() 
            : base("TestGitIntegration1Repository", "/", null, 0, false, "331c7386-f98b-4f51-bb26-d5a0c8db9de0", ".\\RepositoryImages\\TestGitIntegration1Repository331c7386.rximgres")
        {
            _explorer123 = new TestGitIntegration1RepositoryFolders.Explorer123AppFolder(this);
        }

#region Variables

#endregion

        /// <summary>
        /// The Self item info.
        /// </summary>
        [RepositoryItemInfo("331c7386-f98b-4f51-bb26-d5a0c8db9de0")]
        public virtual RepoItemInfo SelfInfo
        {
            get
            {
                return _selfInfo;
            }
        }

        /// <summary>
        /// The Explorer123 folder.
        /// </summary>
        [RepositoryFolder("465033ac-4b94-42e3-af62-05115e73397e")]
        public virtual TestGitIntegration1RepositoryFolders.Explorer123AppFolder Explorer123
        {
            get { return _explorer123; }
        }
    }

    /// <summary>
    /// Inner folder classes.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", "7.1")]
    public partial class TestGitIntegration1RepositoryFolders
    {
        /// <summary>
        /// The Explorer123AppFolder folder.
        /// </summary>
        [RepositoryFolder("465033ac-4b94-42e3-af62-05115e73397e")]
        public partial class Explorer123AppFolder : RepoGenBaseFolder
        {
            RepoItemInfo _listitembinInfo;

            /// <summary>
            /// Creates a new Explorer123  folder.
            /// </summary>
            public Explorer123AppFolder(RepoGenBaseFolder parentFolder) :
                    base("Explorer123", "/desktop[@processname='explorer']", parentFolder, 30000, null, true, "465033ac-4b94-42e3-af62-05115e73397e", "")
            {
                _listitembinInfo = new RepoItemInfo(this, "ListItemBin", "?/?/list[@controlid='1']/listitem[@text='bin']", 30000, null, "abb137a5-0f7c-40c7-9409-198c85a8e5fc");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("465033ac-4b94-42e3-af62-05115e73397e")]
            public virtual Ranorex.Desktop Self
            {
                get
                {
                    return _selfInfo.CreateAdapter<Ranorex.Desktop>(true);
                }
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("465033ac-4b94-42e3-af62-05115e73397e")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The ListItemBin item.
            /// </summary>
            [RepositoryItem("abb137a5-0f7c-40c7-9409-198c85a8e5fc")]
            public virtual Ranorex.ListItem ListItemBin
            {
                get
                {
                    return _listitembinInfo.CreateAdapter<Ranorex.ListItem>(true);
                }
            }

            /// <summary>
            /// The ListItemBin item info.
            /// </summary>
            [RepositoryItemInfo("abb137a5-0f7c-40c7-9409-198c85a8e5fc")]
            public virtual RepoItemInfo ListItemBinInfo
            {
                get
                {
                    return _listitembinInfo;
                }
            }
        }

    }
#pragma warning restore 0436
}