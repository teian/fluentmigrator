#region License
// Copyright (c) 2007-2018, Fluent Migrator Project
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
// http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
#endregion

using JetBrains.Annotations;

namespace FluentMigrator.Runner
{
    /// <summary>
    /// Interface to load migrations tagged with a profile name
    /// </summary>
    public interface IProfileLoader
    {
        /// <summary>
        /// Apply all loaded profiles with the given runner
        /// </summary>
        /// <param name="runner">The migration ruinner</param>
        void ApplyProfiles([NotNull] IMigrationRunner runner);
    }
}
