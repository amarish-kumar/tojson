using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ToJSON {
    public static class ToJSONExtensionMethod {
        public static string ToJSON(this object obj) {
            return JsonConvert.SerializeObject(obj, Formatting.Indented,
                new JsonSerializerSettings {
                    NullValueHandling = NullValueHandling.Ignore,
                    ReferenceLoopHandling = ReferenceLoopHandling.Ignore
                });
        }
    }
}
