﻿// ----------------------------------------------------------------------------------
//
// Copyright Microsoft Corporation
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// http://www.apache.org/licenses/LICENSE-2.0
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// ----------------------------------------------------------------------------------


using Microsoft.WindowsAzure.Commands.ScenarioTest;
using Microsoft.WindowsAzure.Commands.Test.Utilities.Common;
using Xunit;

namespace Microsoft.Azure.Commands.Management.Storage.Test.ScenarioTests
{
    public class StorageAccountTests : RMTestBase
    {
        [Fact(Skip = "TODO, [#108248038]: Enable scenario tests")]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        public void TestStorageAccount()
        {
            TestController.NewInstance.RunPsTest("Test-StorageAccount");
        }

        [Fact(Skip = "TODO, [#108248038]: Enable scenario tests")]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        public void TestNewAzureStorageAccount()
        {
            TestController.NewInstance.RunPsTest("Test-NewAzureStorageAccount");
        }

        [Fact(Skip = "TODO, [#108248038]: Enable scenario tests")]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        public void TestGetAzureStorageAccount()
        {
            TestController.NewInstance.RunPsTest("Test-GetAzureStorageAccount");
        }

        [Fact(Skip = "TODO, [#108248038]: Enable scenario tests")]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        public void TestSetAzureStorageAccount()
        {
            TestController.NewInstance.RunPsTest("Test-SetAzureStorageAccount");
        }

        [Fact(Skip = "TODO, [#108248038]: Enable scenario tests")]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        public void TestRemoveAzureStorageAccount()
        {
            TestController.NewInstance.RunPsTest("Test-RemoveAzureStorageAccount");
        }

        [Fact(Skip = "TODO, [#108248038]: Enable scenario tests")]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        public void TestGetAzureStorageAccountKey()
        {
            TestController.NewInstance.RunPsTest("Test-GetAzureStorageAccountKey");
        }

        [Fact(Skip = "TODO, [#108248038]: Enable scenario tests")]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        public void TestNewAzureStorageAccountKey()
        {
            TestController.NewInstance.RunPsTest("Test-NewAzureStorageAccountKey");
        }

        [Fact(Skip = "TODO, [#108248038]: Enable scenario tests")]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        public void TestPipingGetAccountToGetKey()
        {
            TestController.NewInstance.RunPsTest("Test-PipingGetAccountToGetKey");
        }
 
        [Fact(Skip = "TODO, [#108248038]: Enable scenario tests")]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        public void TestPipingSetStorageAccount()
        {
            TestController.NewInstance.RunPsTest("Test-PipingToSetAzureRmCurrentStorageAccount");
        }

        [Fact(Skip = "TODO, [#108248038]: Enable scenario tests")]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        public void TestSetCurrentStorageAccount()
        {
            TestController.NewInstance.RunPsTest("Test-SetAzureRmCurrentStorageAccount");
        }

    }
}
