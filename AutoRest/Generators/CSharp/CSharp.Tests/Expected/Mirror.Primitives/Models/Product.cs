// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Fixtures.MirrorPrimitives.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;

    public partial class Product
    {
        /// <summary>
        /// Initializes a new instance of the Product class.
        /// </summary>
        public Product() { }

        /// <summary>
        /// Initializes a new instance of the Product class.
        /// </summary>
        public Product(int? integer = default(int?), int? intProperty = default(int?), long? longProperty = default(long?), double? number = default(double?), double? floatProperty = default(double?), double? doubleProperty = default(double?), byte[] byteProperty = default(byte[]), string stringProperty = default(string), byte[] base64url = default(byte[]), Guid? uuid = default(Guid?), string enumProperty = default(string), bool? boolean = default(bool?), DateTime? date = default(DateTime?), DateTime? dateTime = default(DateTime?), IList<int?> integerArray = default(IList<int?>), IList<int?> intArray = default(IList<int?>), IList<long?> longArray = default(IList<long?>), IList<double?> numberArray = default(IList<double?>), IList<double?> floatArray = default(IList<double?>), IList<double?> doubleArray = default(IList<double?>), IList<byte[]> byteArray = default(IList<byte[]>), IList<bool?> booleanArray = default(IList<bool?>), IList<string> stringArray = default(IList<string>), IList<byte[]> base64urlArray = default(IList<byte[]>), IList<DateTime?> dateArray = default(IList<DateTime?>), IList<DateTime?> dateTimeArray = default(IList<DateTime?>), IList<Guid?> uuidArray = default(IList<Guid?>))
        {
            Integer = integer;
            IntProperty = intProperty;
            LongProperty = longProperty;
            Number = number;
            FloatProperty = floatProperty;
            DoubleProperty = doubleProperty;
            ByteProperty = byteProperty;
            StringProperty = stringProperty;
            Base64url = base64url;
            Uuid = uuid;
            EnumProperty = enumProperty;
            Boolean = boolean;
            Date = date;
            DateTime = dateTime;
            IntegerArray = integerArray;
            IntArray = intArray;
            LongArray = longArray;
            NumberArray = numberArray;
            FloatArray = floatArray;
            DoubleArray = doubleArray;
            ByteArray = byteArray;
            BooleanArray = booleanArray;
            StringArray = stringArray;
            Base64urlArray = base64urlArray;
            DateArray = dateArray;
            DateTimeArray = dateTimeArray;
            UuidArray = uuidArray;
        }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "integer")]
        public int? Integer { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "int")]
        public int? IntProperty { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "long")]
        public long? LongProperty { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "number")]
        public double? Number { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "float")]
        public double? FloatProperty { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "double")]
        public double? DoubleProperty { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "byte")]
        public byte[] ByteProperty { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "string")]
        public string StringProperty { get; set; }

        /// <summary>
        /// </summary>
        [JsonConverter(typeof(Base64UrlJsonConverter))]
        [JsonProperty(PropertyName = "base64url")]
        public byte[] Base64url { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "uuid")]
        public Guid? Uuid { get; set; }

        /// <summary>
        /// Gets or sets possible values include: 'red', 'blue', 'green'
        /// </summary>
        [JsonProperty(PropertyName = "enum")]
        public string EnumProperty { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "boolean")]
        public bool? Boolean { get; set; }

        /// <summary>
        /// </summary>
        [JsonConverter(typeof(DateJsonConverter))]
        [JsonProperty(PropertyName = "date")]
        public DateTime? Date { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "dateTime")]
        public DateTime? DateTime { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "integerArray")]
        public IList<int?> IntegerArray { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "intArray")]
        public IList<int?> IntArray { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "longArray")]
        public IList<long?> LongArray { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "numberArray")]
        public IList<double?> NumberArray { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "floatArray")]
        public IList<double?> FloatArray { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "doubleArray")]
        public IList<double?> DoubleArray { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "byteArray")]
        public IList<byte[]> ByteArray { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "booleanArray")]
        public IList<bool?> BooleanArray { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "stringArray")]
        public IList<string> StringArray { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "base64urlArray")]
        public IList<byte[]> Base64urlArray { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "dateArray")]
        public IList<DateTime?> DateArray { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "dateTimeArray")]
        public IList<DateTime?> DateTimeArray { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "uuidArray")]
        public IList<Guid?> UuidArray { get; set; }

    }
}
