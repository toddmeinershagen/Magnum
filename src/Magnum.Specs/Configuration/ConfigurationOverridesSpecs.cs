// Copyright 2007-2010 The Apache Software Foundation.
// 
// Licensed under the Apache License, Version 2.0 (the "License"); you may not use 
// this file except in compliance with the License. You may obtain a copy of the 
// License at 
// 
//     http://www.apache.org/licenses/LICENSE-2.0 
// 
// Unless required by applicable law or agreed to in writing, software distributed 
// under the License is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR 
// CONDITIONS OF ANY KIND, either express or implied. See the License for the 
// specific language governing permissions and limitations under the License.
namespace Magnum.Specs.Configuration
{
    using System.IO;
    using System.Linq;
    using Magnum.Configuration;
    using NUnit.Framework;
    using TestFramework;

    [TestFixture]
    public class ConfigurationOverridesSpecs
    {
        ConfigurationStore _store;
        //TODO: Get rid of the UGLY 'Entries'
        const string GLOBAL_CONF = @"[{Key:""key1"",Value:""global-value-1""},{Key:""key2"",Value:""global-value-2""}]";
        const string LOCAL_CONF = @"[{Key:""key1"",Value:""local-value-1""}]";

        [SetUp]
        public void Should_be_able_to_add_multiple_configuration_files_to_be_loaded()
        {
            _store = new ConfigurationStore();
            if(File.Exists("global.json"))
                File.Delete("global.json");
            if (File.Exists("local.json"))
                File.Delete("local.json");

            File.AppendAllText("global.json",GLOBAL_CONF);
            File.AppendAllText("local.json",LOCAL_CONF);

            _store.AddJsonFile("global.json");
            _store.AddJsonFile("local.json");
        }
        
//        [Test]
//        public void Should_be_able_override_values()
//        {
//            var entries = _store.GetEntries();
//            entries.First().Value.ShouldEqual("local-value-1");
//            entries.Skip(1).First().Value.ShouldEqual("global-value-2");
//        }
//
//        [Test]
//        public void Entries_should_track_history()
//        {
//            var entries = _store.GetEntries();
//            var entry = entries.First();
//
//            entry.History.Count.ShouldEqual(2);
//
//            entry.History.First().Source.ShouldEqual("local.json");
//            entry.History.Skip(1).First().Source.ShouldEqual("global.json");
//
//            entry.History.First().Value.ShouldEqual("local-value-1");
//            entry.History.Skip(1).First().Value.ShouldEqual("global-value-1");
//        }

    }
}