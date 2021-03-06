using System.Collections.Generic;
using Newtonsoft.Json.Linq;

namespace Orchard.Core.Settings.Metadata.Records
{
    public class ContentPartDefinitionRecord
    {
        public ContentPartDefinitionRecord()
        {
            ContentPartFieldDefinitionRecords = new List<ContentPartFieldDefinitionRecord>();
            Settings = new JObject();
        }

        public string Name { get; set; }

        public bool Hidden { get; set; }

        /// <summary>
        /// Gets or sets the settings of a part, like description, or any property that a module would attach
        /// to a part.
        /// </summary>
        public JObject Settings { get; set; }

        public IList<ContentPartFieldDefinitionRecord> ContentPartFieldDefinitionRecords { get; set; }
    }
}