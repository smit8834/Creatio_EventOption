﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: CaseSLMEventListenerSchema

	/// <exclude/>
	public class CaseSLMEventListenerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public CaseSLMEventListenerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public CaseSLMEventListenerSchema(CaseSLMEventListenerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("a34f73f9-d6f2-4e58-8349-70275d45d272");
			Name = "CaseSLMEventListener";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("b11d550e-0087-4f53-ae17-fb00d41102cf");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,229,27,105,111,227,54,246,179,7,152,255,160,241,2,3,25,72,132,76,231,232,180,105,166,176,29,187,53,54,87,227,204,22,216,162,40,20,137,113,180,85,40,151,148,156,122,219,252,247,125,60,69,82,148,172,164,45,182,219,253,146,88,212,227,227,187,248,46,82,21,205,240,42,88,110,105,137,238,14,159,63,171,140,199,104,90,228,57,74,202,172,192,52,250,10,97,68,178,196,5,57,142,203,216,29,59,201,240,79,122,236,10,17,18,211,226,166,4,108,119,119,5,246,190,32,168,101,56,58,158,180,189,153,225,50,43,51,68,119,189,143,102,27,132,203,86,176,121,156,148,5,17,120,158,63,195,241,29,162,235,56,65,22,24,190,201,86,21,137,153,32,158,63,251,229,249,179,129,192,52,37,136,141,69,115,248,87,17,116,85,172,86,57,140,115,68,131,191,17,180,2,248,96,154,199,148,126,30,76,99,138,150,39,167,156,150,147,12,196,4,210,228,112,223,113,58,183,214,139,112,153,220,162,187,248,12,136,9,142,130,33,155,59,28,125,15,192,235,234,58,207,146,32,97,56,189,40,131,207,131,9,12,123,112,194,236,95,248,130,154,178,121,134,242,20,72,187,32,217,38,46,145,120,185,22,15,193,71,138,8,48,142,133,250,131,31,42,235,249,208,4,21,139,5,63,36,176,176,245,130,150,32,158,36,248,170,202,210,224,135,117,65,202,56,63,39,217,42,195,139,20,216,98,195,209,69,76,40,10,135,199,179,201,252,205,171,79,222,236,207,223,188,155,236,191,122,243,234,96,255,245,219,207,62,217,63,56,120,123,48,25,191,61,126,55,125,253,126,56,58,148,244,35,156,10,22,108,126,46,72,177,70,132,169,188,133,39,78,8,87,26,74,153,240,78,178,27,148,108,147,28,1,61,76,171,131,193,10,149,135,1,133,63,236,233,193,55,59,47,104,61,121,218,123,242,117,81,228,193,18,228,81,209,233,109,140,87,168,115,146,208,50,159,115,134,80,186,140,55,53,173,29,243,218,4,115,138,202,219,162,85,211,155,2,248,178,150,8,71,114,17,216,220,232,42,3,35,140,185,214,217,35,40,206,177,133,104,90,17,2,134,198,44,6,188,68,41,31,213,220,112,196,73,28,112,110,50,122,86,148,243,140,208,82,226,226,242,188,32,104,147,21,21,93,224,18,145,77,156,135,220,148,24,174,171,237,26,164,93,228,213,29,254,71,156,87,232,11,166,132,15,225,112,145,14,71,123,6,85,114,13,139,76,103,173,47,31,77,55,236,165,118,66,20,24,16,115,9,82,134,61,70,80,122,142,135,146,146,243,53,194,103,232,94,115,228,146,250,224,209,1,151,197,56,207,213,36,26,10,147,3,18,22,169,82,201,18,49,143,28,48,186,52,156,28,59,10,48,186,15,196,67,232,48,59,226,147,7,145,96,33,28,78,79,134,123,1,23,163,247,5,88,42,225,146,104,121,63,195,169,245,118,78,138,187,112,104,237,169,225,40,26,83,14,175,128,190,189,5,25,41,12,130,43,0,90,208,217,79,21,72,72,44,192,28,2,120,61,96,44,148,124,171,217,231,36,69,100,178,61,70,52,241,80,25,196,84,114,46,228,127,156,113,182,99,178,229,38,179,23,104,125,113,209,105,42,47,81,82,144,148,94,21,92,248,82,132,237,147,149,49,235,141,129,209,207,165,38,3,166,167,232,38,174,242,50,84,0,18,94,196,139,240,120,50,251,25,37,21,196,155,32,189,214,63,155,59,106,134,41,196,147,227,73,61,20,142,148,1,12,234,153,17,95,249,138,196,152,10,251,10,23,180,200,121,152,58,65,27,148,71,151,40,78,89,212,205,74,240,120,146,148,65,73,182,10,213,192,99,70,145,192,142,216,92,208,2,144,247,65,131,15,178,155,32,20,155,197,191,21,180,93,4,71,30,89,4,47,95,58,2,123,225,129,26,213,203,13,58,116,21,141,211,180,73,139,229,31,172,181,20,251,124,239,137,31,174,242,186,56,51,108,77,33,122,208,191,230,5,73,16,167,106,234,33,56,236,224,66,163,48,180,42,52,102,170,85,65,61,128,241,150,201,173,22,144,49,233,18,82,181,235,56,249,209,59,141,255,147,46,199,231,121,118,208,255,180,205,164,244,216,165,67,88,120,22,39,183,33,225,195,134,169,177,109,248,113,157,194,58,174,39,147,190,195,240,51,82,24,209,18,149,181,5,238,5,13,135,34,22,137,184,106,71,246,172,211,34,205,110,50,238,192,61,19,21,187,209,199,50,57,43,238,235,185,210,163,117,251,49,185,236,223,209,118,52,82,155,75,169,230,193,27,13,120,168,244,71,70,35,34,212,106,224,63,148,184,55,49,9,214,206,180,217,242,27,233,218,68,174,38,210,203,111,42,68,182,174,120,35,19,226,52,198,241,10,145,166,200,5,245,158,101,34,136,166,227,244,46,195,151,217,234,182,164,176,234,13,120,22,212,14,15,187,24,66,158,88,78,136,142,134,29,232,1,92,69,34,99,71,90,193,65,206,102,114,96,166,39,44,110,158,229,128,4,200,241,33,21,41,161,0,249,54,43,111,181,238,104,168,54,56,127,7,27,115,29,147,140,22,152,165,3,17,215,183,148,141,88,5,12,97,79,197,107,65,5,115,152,178,60,96,37,84,9,86,130,227,235,28,165,225,144,177,2,160,130,157,5,214,210,21,107,13,107,63,184,67,14,162,58,144,91,93,113,45,144,124,69,138,106,221,166,121,197,147,42,241,66,207,58,123,193,73,177,202,18,200,219,33,179,230,129,101,89,66,17,88,130,192,71,86,16,49,165,188,39,199,255,32,81,215,34,150,222,237,176,93,76,2,25,229,177,194,17,139,218,129,1,2,251,236,18,181,139,195,100,85,33,105,181,87,115,114,187,60,22,244,172,202,115,1,107,4,81,195,146,221,185,180,197,148,193,196,132,162,13,189,186,169,96,109,153,13,172,16,123,42,92,178,224,125,160,245,75,16,88,47,54,247,241,131,38,11,234,208,82,77,246,80,68,191,59,248,94,76,49,1,59,125,132,246,105,212,8,204,214,236,29,217,120,35,80,179,241,229,58,198,1,184,248,27,240,215,56,97,40,67,53,60,226,238,61,216,175,23,28,121,72,94,90,137,129,25,102,250,206,96,197,31,58,150,93,132,5,62,205,48,196,1,10,8,106,178,162,171,2,74,100,249,230,9,56,191,46,42,226,195,200,199,159,128,239,56,222,250,208,177,97,47,54,168,33,149,247,245,215,201,61,52,105,36,112,187,237,244,67,240,138,229,148,45,14,118,122,139,146,31,199,56,85,117,213,212,76,118,13,255,218,172,187,44,23,46,172,93,238,130,146,84,168,181,128,115,139,190,214,248,140,12,95,108,69,86,111,45,208,136,199,156,79,12,246,10,42,153,108,89,151,168,81,123,213,158,3,124,191,187,68,235,242,210,29,137,37,91,252,134,139,175,115,55,55,128,193,226,142,209,141,161,112,29,237,125,160,174,113,202,141,109,109,186,157,243,156,240,172,75,122,11,136,217,91,43,66,211,174,253,221,163,163,134,152,123,24,119,155,25,65,200,149,61,34,157,16,253,151,108,199,93,235,183,45,241,167,177,74,230,82,26,19,230,8,42,43,214,199,56,158,132,126,45,215,30,227,17,102,205,185,77,51,202,124,146,104,128,75,165,202,180,140,181,103,191,160,144,84,225,213,135,176,206,169,152,141,168,60,106,40,201,97,197,137,51,52,217,2,156,157,6,241,12,208,89,168,67,180,2,166,46,134,120,243,40,97,149,24,163,238,151,64,246,160,147,200,96,142,141,241,61,24,243,71,102,230,28,196,30,121,208,101,18,119,136,148,33,118,9,81,235,255,206,11,143,124,252,36,17,155,174,95,205,126,78,208,186,12,125,170,81,155,115,48,184,41,64,206,80,112,135,66,67,32,88,6,192,73,203,176,45,230,90,119,187,60,82,141,164,197,27,213,0,202,39,169,158,69,47,103,215,207,205,117,251,185,135,182,178,148,135,88,214,148,190,42,192,79,53,91,198,60,43,4,7,166,109,47,92,204,112,117,7,213,3,72,89,25,250,8,176,192,236,21,252,118,106,62,19,88,39,178,138,126,208,161,240,139,98,139,177,51,4,224,207,113,149,135,102,184,182,224,149,53,108,152,53,108,132,53,24,182,89,83,61,138,198,120,27,122,75,243,29,244,121,232,145,114,145,4,213,106,49,193,148,203,144,13,5,70,160,110,129,133,225,70,180,44,88,179,12,67,153,192,219,104,47,228,160,168,140,40,192,156,231,169,236,108,4,191,254,234,153,125,100,204,174,161,53,82,53,163,189,33,193,53,47,142,48,198,224,122,193,86,120,51,130,242,145,186,65,45,252,143,225,226,190,251,94,237,140,225,130,94,196,224,190,181,107,131,129,121,134,227,220,120,190,68,180,200,55,72,122,181,7,75,155,47,128,4,65,192,130,134,106,221,61,181,90,71,43,133,37,130,138,118,41,120,203,96,21,174,105,189,189,143,120,123,153,143,14,235,176,85,228,169,26,101,177,208,58,29,0,145,54,99,125,19,179,17,4,105,27,170,71,224,145,162,49,9,3,149,42,240,214,84,245,172,40,179,155,45,59,250,208,130,96,81,209,18,145,246,104,11,230,39,46,42,122,203,103,101,8,194,183,250,113,36,206,55,197,33,234,150,49,240,69,3,250,3,11,182,1,132,108,216,253,21,131,27,147,21,108,34,92,134,67,59,150,51,183,229,68,119,237,172,36,174,72,16,14,89,182,32,181,223,81,81,135,83,227,210,16,157,70,48,189,53,16,137,254,42,166,193,20,106,81,37,207,92,103,119,235,114,11,78,34,112,94,186,59,89,218,150,91,243,19,46,166,148,229,35,182,80,46,235,23,134,92,12,240,78,102,234,18,222,187,128,193,147,133,177,235,0,129,167,94,114,244,172,184,23,241,66,129,45,176,60,240,99,15,255,44,176,14,125,3,65,163,19,89,189,68,237,153,232,251,25,217,18,38,139,230,252,95,214,200,122,218,81,70,149,44,206,55,136,164,21,234,36,131,57,114,214,221,177,167,168,146,66,41,245,75,30,204,100,192,227,191,15,141,245,180,215,224,65,231,156,168,88,35,12,67,5,8,231,165,102,125,119,71,151,87,154,85,142,198,235,117,158,89,45,92,54,233,69,51,128,26,130,51,142,189,4,177,231,234,221,163,136,53,49,170,163,165,90,56,134,181,170,151,140,178,14,201,128,151,48,86,19,209,187,150,136,113,84,39,240,180,17,109,158,233,153,214,48,48,78,227,158,176,83,157,238,173,139,67,219,130,6,151,255,189,59,92,219,214,5,41,54,89,42,15,131,154,27,92,97,97,28,119,200,134,103,105,198,123,175,138,56,80,99,35,212,210,234,38,84,54,67,52,155,206,121,159,37,155,62,212,254,65,132,52,172,159,27,135,189,246,46,65,245,165,196,210,93,131,158,206,205,155,163,152,152,12,141,111,160,50,184,68,197,26,97,209,189,216,37,163,39,10,73,73,169,69,88,255,43,174,226,255,217,23,60,232,200,208,67,62,203,230,85,163,33,191,166,228,89,83,45,227,155,211,14,222,85,188,235,250,201,42,222,246,130,53,59,136,163,129,40,208,161,100,83,69,149,145,165,192,158,129,60,171,217,74,123,209,178,163,62,138,235,4,98,197,37,228,253,104,104,231,102,148,141,201,62,152,3,217,210,230,107,105,200,136,102,140,211,134,161,247,25,187,43,33,187,41,134,213,49,133,7,117,45,250,185,97,141,156,193,95,143,4,101,145,146,149,235,44,181,189,14,174,129,154,31,15,93,196,162,166,221,141,215,241,131,187,208,234,210,120,55,230,182,228,165,129,220,242,61,246,14,226,26,234,125,179,204,188,3,38,168,24,62,238,154,132,145,84,56,119,185,106,165,215,189,5,191,198,21,181,226,135,186,179,38,13,192,142,73,242,70,22,47,17,158,124,21,75,97,89,176,6,164,184,48,21,164,164,38,192,190,74,85,175,227,38,78,41,225,87,181,66,235,238,83,95,174,45,51,72,27,119,152,68,226,108,203,192,116,181,15,94,75,48,123,11,2,123,159,190,144,220,40,222,190,144,68,230,111,225,212,187,177,87,255,73,155,247,147,86,210,251,168,215,90,98,147,62,105,33,225,7,250,175,98,4,103,190,94,214,179,169,246,152,30,154,73,108,182,163,121,166,207,47,187,3,176,45,13,53,190,192,55,5,187,58,15,89,18,135,117,111,81,237,217,144,48,216,232,254,88,55,116,21,116,251,253,89,81,96,179,211,92,182,99,217,213,49,95,141,221,163,216,173,43,111,243,46,81,141,183,103,31,99,104,144,98,158,102,187,157,72,142,203,205,130,61,57,178,69,193,174,190,71,82,139,78,171,241,72,188,102,46,154,61,255,27,164,249,53,202,215,242,250,115,129,203,56,41,213,139,230,181,187,46,229,200,201,139,52,186,42,150,60,50,135,186,117,199,88,246,81,163,219,217,221,153,189,41,196,250,202,155,252,112,192,131,119,228,73,205,124,214,226,73,169,100,78,161,210,60,254,125,132,217,29,237,163,116,103,242,255,141,158,44,190,127,39,61,233,15,32,166,113,158,84,57,155,136,200,29,181,58,214,109,201,167,53,229,156,87,112,226,188,198,200,65,219,110,54,245,213,181,93,218,113,101,107,190,79,51,1,238,182,1,100,136,124,132,11,106,208,171,239,160,216,97,154,47,194,184,101,18,211,7,80,194,201,48,153,189,124,41,176,60,133,179,23,126,206,4,194,223,200,94,119,120,236,96,200,8,141,127,224,177,160,239,144,62,24,46,17,217,100,9,90,148,232,142,31,183,170,129,11,190,187,216,192,5,201,10,2,246,38,95,87,107,246,1,20,191,150,15,35,193,67,199,25,163,248,24,164,221,228,125,59,194,188,154,192,107,41,54,174,128,64,143,242,106,70,35,121,143,52,34,25,134,118,87,144,74,213,223,198,89,201,28,136,55,53,226,131,247,2,98,94,16,117,180,210,248,240,235,245,251,183,159,77,223,205,62,221,159,78,166,147,253,55,239,223,77,246,39,227,183,175,247,63,253,244,253,193,251,249,236,221,236,237,103,175,135,182,242,212,82,234,232,211,183,74,187,81,185,193,87,126,188,38,46,38,152,212,127,25,108,100,27,89,188,123,76,190,32,230,23,234,140,181,129,194,219,170,111,96,145,252,134,225,198,115,252,107,30,254,22,205,163,95,53,201,60,245,45,220,51,223,86,227,155,103,121,46,67,197,24,167,227,36,97,183,237,252,162,98,6,185,91,64,234,179,63,225,36,221,111,1,129,182,221,40,116,232,18,56,234,147,44,193,112,141,227,99,143,240,199,68,80,99,208,155,71,98,104,164,32,122,233,189,199,44,98,6,214,221,252,73,41,55,249,11,122,177,166,167,183,176,214,198,91,189,108,31,222,52,116,123,240,238,241,17,98,81,2,106,148,42,195,147,143,193,38,35,37,216,179,229,109,3,207,77,17,187,222,104,191,68,85,111,40,85,26,153,62,89,193,216,142,92,142,158,223,99,68,140,103,126,99,220,156,101,245,116,157,65,179,103,168,94,217,238,127,207,40,204,122,139,141,127,20,106,125,32,90,64,109,69,96,37,121,251,20,47,192,247,17,238,147,139,235,127,177,78,8,5,164,236,243,13,177,115,39,136,181,20,248,71,193,99,178,162,129,110,93,95,179,96,109,78,87,243,84,56,240,251,3,1,197,186,53,2,191,237,79,252,36,46,227,205,147,233,147,115,93,226,122,180,32,23,120,121,114,10,78,119,94,225,196,200,255,120,196,99,87,148,36,253,2,179,58,5,182,35,165,174,249,236,221,161,250,179,214,151,189,71,45,55,78,36,176,123,219,192,26,174,207,135,173,97,171,170,61,84,245,129,157,3,200,225,230,23,195,71,237,183,182,12,23,213,152,87,251,14,231,235,224,246,196,189,85,233,236,188,193,167,115,126,200,210,169,114,214,196,252,19,106,124,135,196,60,119,120,237,254,163,121,1,167,153,115,57,222,64,140,218,131,15,255,1,109,66,229,36,185,65,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("a34f73f9-d6f2-4e58-8349-70275d45d272"));
		}

		#endregion

	}

	#endregion

}

