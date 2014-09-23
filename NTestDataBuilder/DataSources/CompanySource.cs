﻿using System.Collections.Generic;
using System.Linq;
using NTestDataBuilder.DataSources.FileData;
using NTestDataBuilder.DataSources.Generators;

namespace NTestDataBuilder.DataSources
{
    /// <summary>
    /// Free sample data for testing obtained from http://www.briandunning.com/sample-data/
    /// </summary>
    public class CompanySource : DataSource<string>
    {
        /// <inheritdoc />
        public CompanySource() 
            : base() { }

        /// <inheritdoc />
        public CompanySource(IGenerator generator) 
            : base(generator) { }

        /// <inheritdoc />
        protected override IList<string> InitializeDataSource()
        {
            return FileDataRepository.People
                .Select(person => person.CompanyName)
                .Distinct()
                .ToList();
        }
    }
}
