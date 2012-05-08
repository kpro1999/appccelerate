//-------------------------------------------------------------------------------
// <copyright file="DirectoryLogExtension.cs" company="Appccelerate">
//   Copyright (c) 2008-2012
//
//   Licensed under the Apache License, Version 2.0 (the "License");
//   you may not use this file except in compliance with the License.
//   You may obtain a copy of the License at
//
//       http://www.apache.org/licenses/LICENSE-2.0
//
//   Unless required by applicable law or agreed to in writing, software
//   distributed under the License is distributed on an "AS IS" BASIS,
//   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//   See the License for the specific language governing permissions and
//   limitations under the License.
// </copyright>
//-------------------------------------------------------------------------------

namespace Appccelerate.SourceTemplates.Log4Net
{
    using System;
    using System.Globalization;
    using System.IO;
    using System.Reflection;
    using System.Security.AccessControl;

    using Appccelerate.IO.Access;

    using log4net;

    /// <summary>
    /// Directory access extension which logs actions with log4net.
    /// </summary>
    public class DirectoryLogExtension : DirectoryExtensionBase
    {
        private readonly ILog log;

        /// <summary>
        /// Initializes a new instance of the <see cref="DirectoryLogExtension"/> class.
        /// </summary>
        public DirectoryLogExtension()
        {
            this.log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType.FullName);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DirectoryLogExtension"/> class.
        /// </summary>
        /// <param name="logger">The logger.</param>
        public DirectoryLogExtension(string logger)
        {
            this.log = LogManager.GetLogger(logger);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DirectoryLogExtension"/> class.
        /// </summary>
        /// <param name="logger">The logger.</param>
        public DirectoryLogExtension(ILog logger)
        {
            this.log = logger;
        }

        /// <inheritdoc />
        public override void BeginExists(string path)
        {
            base.BeginExists(path);

            this.log.DebugFormat(CultureInfo.InvariantCulture, "Checking if file {0} exists.", path);
        }

        /// <inheritdoc />
        public override void EndExists(bool result, string path)
        {
            base.EndExists(result, path);
        }

        /// <inheritdoc />
        public override void FailExists(ref Exception exception)
        {
            base.FailExists(ref exception);

            this.log.Error("Exception occurred while checking the directory for existance.", exception);
        }

        /// <inheritdoc />
        public override void BeginCreateDirectory(string path)
        {
        }

        /// <inheritdoc />
        public override void EndCreateDirectory(DirectoryInfo result, string path)
        {
        }

        /// <inheritdoc />
        public override void FailCreateDirectory(ref Exception exception)
        {
            base.FailCreateDirectory(ref exception);

            this.log.Error("Exception occurred while creating a directory.", exception);
        }

        /// <inheritdoc />
        public override void BeginCreateDirectory(string path, DirectorySecurity directorySecurity)
        {
        }

        /// <inheritdoc />
        public override void EndCreateDirectory(DirectoryInfo result, string path, DirectorySecurity directorySecurity)
        {
        }

        /// <inheritdoc />
        public override void BeginDelete(string path, bool recursive)
        {
        }

        /// <inheritdoc />
        public override void EndDelete(string path, bool recursive)
        {
        }

        /// <inheritdoc />
        public override void FailDelete(ref Exception exception)
        {
            base.FailDelete(ref exception);

            this.log.Error("Exception occurred while deleting a directory.", exception);
        }

        /// <inheritdoc />
        public override void BeginDelete(string path)
        {
        }

        /// <inheritdoc />
        public override void EndDelete(string path)
        {
        }

        /// <inheritdoc />
        public override void BeginGetFiles(string path)
        {
        }

        /// <inheritdoc />
        public override void EndGetFiles(string[] result, string path)
        {
        }

        /// <inheritdoc />
        public override void FailGetFiles(ref Exception exception)
        {
            base.FailGetFiles(ref exception);

            this.log.Error("Exception occurred while getting all files of a directory.", exception);
        }

        /// <inheritdoc />
        public override void BeginGetFiles(string path, string searchPattern)
        {
        }

        /// <inheritdoc />
        public override void EndGetFiles(string[] result, string path, string searchPattern)
        {
        }

        /// <inheritdoc />
        public override void BeginGetFiles(string path, string searchPattern, SearchOption searchOption)
        {
        }

        /// <inheritdoc />
        public override void EndGetFiles(string[] result, string path, string searchPattern, SearchOption searchOption)
        {
        }

        /// <inheritdoc />
        public override void BeginGetDirectories(string path)
        {
        }

        /// <inheritdoc />
        public override void EndGetDirectories(string[] result, string path)
        {
        }

        /// <inheritdoc />
        public override void FailGetDirectories(ref Exception exception)
        {
            base.FailGetDirectories(ref exception);

            this.log.Error("Exception occurred while getting all directories.", exception);
        }

        /// <inheritdoc />
        public override void BeginGetDirectories(string path, string searchPattern)
        {
        }

        /// <inheritdoc />
        public override void EndGetDirectories(string[] result, string path, string searchPattern)
        {
        }

        /// <inheritdoc />
        public override void BeginGetDirectories(string path, string searchPattern, SearchOption searchOption)
        {
        }

        /// <inheritdoc />
        public override void FailGetLastAccessTime(ref Exception exception)
        {
            base.FailGetLastAccessTime(ref exception);

            this.log.Error("Exception occurred while getting the last access time.", exception);
        }

        /// <inheritdoc />
        public override void BeginSetCreationTime(string path, DateTime creationTime)
        {
        }

        /// <inheritdoc />
        public override void EndSetCreationTime(string path, DateTime creationTime)
        {
        }

        /// <inheritdoc />
        public override void FailSetCreationTime(ref Exception exception)
        {
            base.FailSetCreationTime(ref exception);

            this.log.Error("Exception occurred while setting the creation time of a directory.", exception);
        }

        /// <inheritdoc />
        public override void BeginSetCreationTimeUtc(string path, DateTime creationTimeUtc)
        {
        }

        /// <inheritdoc />
        public override void EndSetCreationTimeUtc(string path, DateTime creationTimeUtc)
        {
        }

        /// <inheritdoc />
        public override void FailSetCreationTimeUtc(ref Exception exception)
        {
            base.FailSetCreationTimeUtc(ref exception);

            this.log.Error("Exception occurred while setting the creation time in UTC of a directory.", exception);
        }

        /// <inheritdoc />
        public override void BeginSetCurrentDirectory(string path)
        {
        }

        /// <inheritdoc />
        public override void EndSetCurrentDirectory(string path)
        {
        }

        /// <inheritdoc />
        public override void FailSetCurrentDirectory(ref Exception exception)
        {
            base.FailSetCurrentDirectory(ref exception);

            this.log.Error("Exception occurred while setting the current directory.", exception);
        }

        /// <inheritdoc />
        public override void BeginSetLastAccessTime(string path, DateTime lastAccessTime)
        {
        }

        /// <inheritdoc />
        public override void EndSetLastAccessTime(string path, DateTime lastAccessTime)
        {
        }

        /// <inheritdoc />
        public override void FailSetLastAccessTime(ref Exception exception)
        {
            base.FailSetLastAccessTime(ref exception);

            this.log.Error("Exception occurred while setting the last access time of a directory.", exception);
        }

        /// <inheritdoc />
        public override void BeginSetLastAccessTimeUtc(string path, DateTime lastAccessTimeUtc)
        {
        }

        /// <inheritdoc />
        public override void EndSetLastAccessTimeUtc(string path, DateTime lastAccessTimeUtc)
        {
        }

        /// <inheritdoc />
        public override void FailSetLastAccessTimeUtc(ref Exception exception)
        {
            base.FailSetLastAccessTimeUtc(ref exception);

            this.log.Error("Exception occurred while setting the last access time in UTC of a directory.", exception);
        }

        /// <inheritdoc />
        public override void BeginSetLastWriteTime(string path, DateTime lastWriteTime)
        {
        }

        /// <inheritdoc />
        public override void EndSetLastWriteTime(string path, DateTime lastWriteTime)
        {
        }

        /// <inheritdoc />
        public override void FailSetLastWriteTime(ref Exception exception)
        {
            base.FailSetLastWriteTime(ref exception);

            this.log.Error("Exception occurred while setting the last write time of a directory.", exception);
        }

        /// <inheritdoc />
        public override void BeginSetLastWriteTimeUtc(string path, DateTime lastWriteTimeUtc)
        {
        }

        /// <inheritdoc />
        public override void EndSetLastWriteTimeUtc(string path, DateTime lastWriteTimeUtc)
        {
        }

        /// <inheritdoc />
        public override void FailSetLastWriteTimeUtc(ref Exception exception)
        {
            base.FailSetLastWriteTimeUtc(ref exception);

            this.log.Error("Exception occurred while setting the last write time in UTC of a directory.", exception);
        }

        /// <inheritdoc />
        public override void BeginGetLastAccessTimeUtc(string path)
        {
        }

        /// <inheritdoc />
        public override void EndGetLastAccessTimeUtc(DateTime result, string path)
        {
        }

        /// <inheritdoc />
        public override void FailGetLastAccessTimeUtc(ref Exception exception)
        {
            base.FailGetLastAccessTimeUtc(ref exception);

            this.log.Error("Exception occurred while getting the last acess time in UTC of a directory.", exception);
        }

        /// <inheritdoc />
        public override void BeginGetLastWriteTime(string path)
        {
        }

        /// <inheritdoc />
        public override void EndGetLastWriteTime(DateTime result, string path)
        {
        }

        /// <inheritdoc />
        public override void FailGetLastWriteTime(ref Exception exception)
        {
            base.FailGetLastWriteTime(ref exception);

            this.log.Error("Exception occurred while getting the last write time of a directory.", exception);
        }

        /// <inheritdoc />
        public override void BeginGetLastWriteTimeUtc(string path)
        {
        }

        /// <inheritdoc />
        public override void EndGetLastWriteTimeUtc(DateTime result, string path)
        {
        }

        /// <inheritdoc />
        public override void FailGetLastWriteTimeUtc(ref Exception exception)
        {
            base.FailGetLastWriteTimeUtc(ref exception);

            this.log.Error("Exception occurred while getting the last write time in UTC of a directory.", exception);
        }

        /// <inheritdoc />
        public override void BeginGetLogicalDrives()
        {
        }

        /// <inheritdoc />
        public override void EndGetLogicalDrives(string[] result)
        {
        }

        /// <inheritdoc />
        public override void FailGetLogicalDrives(ref Exception exception)
        {
            base.FailGetLogicalDrives(ref exception);

            this.log.Error("Exception occurred while getting the logical drives.", exception);
        }

        /// <inheritdoc />
        public override void BeginGetParent(string path)
        {
        }

        /// <inheritdoc />
        public override void EndGetParent(DirectoryInfo result, string path)
        {
        }

        /// <inheritdoc />
        public override void FailGetParent(ref Exception exception)
        {
            base.FailGetParent(ref exception);

            this.log.Error("Exception occurred while getting the parent of a directory.", exception);
        }

        /// <inheritdoc />
        public override void BeginMove(string sourceDirName, string destDirName)
        {
        }

        /// <inheritdoc />
        public override void EndMove(string sourceDirName, string destDirName)
        {
        }

        /// <inheritdoc />
        public override void FailMove(ref Exception exception)
        {
            base.FailMove(ref exception);

            this.log.Error("Exception occurred while moving a directory.", exception);
        }

        /// <inheritdoc />
        public override void BeginSetAccessControl(string path, DirectorySecurity directorySecurity)
        {
        }

        /// <inheritdoc />
        public override void EndSetAccessControl(string path, DirectorySecurity directorySecurity)
        {
        }

        /// <inheritdoc />
        public override void FailSetAccessControl(ref Exception exception)
        {
            base.FailSetAccessControl(ref exception);

            this.log.Error("Exception occurred while setting the access control of a directory.", exception);
        }

        /// <inheritdoc />
        public override void EndGetDirectories(string[] result, string path, string searchPattern, SearchOption searchOption)
        {
        }

        /// <inheritdoc />
        public override void BeginGetAccessControl(string path)
        {
        }

        /// <inheritdoc />
        public override void EndGetAccessControl(DirectorySecurity result, string path)
        {
        }

        /// <inheritdoc />
        public override void FailGetAccessControl(ref Exception exception)
        {
            base.FailGetAccessControl(ref exception);

            this.log.Error("Exception occurred while getting the access control of a directory.", exception);
        }

        /// <inheritdoc />
        public override void BeginGetAccessControl(string path, AccessControlSections includeSections)
        {
        }

        /// <inheritdoc />
        public override void EndGetAccessControl(DirectorySecurity result, string path, AccessControlSections includeSections)
        {
        }

        /// <inheritdoc />
        public override void BeginGetCreationTime(string path)
        {
        }

        /// <inheritdoc />
        public override void EndGetCreationTime(DateTime result, string path)
        {
        }

        /// <inheritdoc />
        public override void FailGetCreationTime(ref Exception exception)
        {
            base.FailGetCreationTime(ref exception);

            this.log.Error("Exception occurred while getting the creation time of a directory.", exception);
        }

        /// <inheritdoc />
        public override void BeginGetCreationTimeUtc(string path)
        {
        }

        /// <inheritdoc />
        public override void EndGetCreationTimeUtc(DateTime result, string path)
        {
        }

        /// <inheritdoc />
        public override void FailGetCreationTimeUtc(ref Exception exception)
        {
            base.FailGetCreationTimeUtc(ref exception);

            this.log.Error("Exception occurred while getting the creation time in UTC of a directory.", exception);
        }

        /// <inheritdoc />
        public override void BeginGetCurrentDirectory()
        {
        }

        /// <inheritdoc />
        public override void EndGetCurrentDirectory(string result)
        {
        }

        /// <inheritdoc />
        public override void FailGetCurrentDirectory(ref Exception exception)
        {
            base.FailGetCurrentDirectory(ref exception);

            this.log.Error("Exception occurred while getting the current directory.", exception);
        }

        /// <inheritdoc />
        public override void BeginGetDirectoryRoot(string path)
        {
        }

        /// <inheritdoc />
        public override void EndGetDirectoryRoot(string result, string path)
        {
        }

        /// <inheritdoc />
        public override void FailGetDirectoryRoot(ref Exception exception)
        {
            base.FailGetDirectoryRoot(ref exception);

            this.log.Error("Exception occurred while getting the directory root.", exception);
        }

        /// <inheritdoc />
        public override void BeginGetFileSystemEntries(string path)
        {
        }

        /// <inheritdoc />
        public override void EndGetFileSystemEntries(string[] result, string path)
        {
        }

        /// <inheritdoc />
        public override void FailGetFileSystemEntries(ref Exception exception)
        {
            base.FailGetFileSystemEntries(ref exception);

            this.log.Error("Exception occurred while getting file system entries.", exception);
        }

        /// <inheritdoc />
        public override void BeginGetFileSystemEntries(string path, string searchPattern)
        {
        }

        /// <inheritdoc />
        public override void EndGetFileSystemEntries(string[] result, string path, string searchPattern)
        {
        }

        /// <inheritdoc />
        public override void BeginGetLastAccessTime(string path)
        {
        }

        /// <inheritdoc />
        public override void EndGetLastAccessTime(DateTime result, string path)
        {
        }
    }
}