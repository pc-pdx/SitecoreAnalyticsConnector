﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sitecore.Data;
using Sitecore.Data.Items;
using Sitecore.Rules;
using Sitecore.Rules.Conditions;

namespace LyticsSitecoreConnector.Rules
{
	public class LyticsSegmentMatch<T> : StringOperatorCondition<T>
	where T : RuleContext
	{
		public ID Segment { get; set; }

		protected override bool Execute(T ruleContext)
		{
			Item segment = ruleContext.Item.Database.GetItem(Segment);
			return LyticsContext.Service.GetCurrentUserSegmentIds().Contains(segment["Segment Id"]);
		}
	}
}
