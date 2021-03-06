// This file is licensed to you under the MIT license.
// See the LICENSE file in the project root for full license information.

namespace Kangaroo.Models
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public interface IHasAuditLog
    {
        public string CreatedByUserName { get; set; }

        public DateTimeOffset CreatedAt { get; set; }

        public string UpdatedByUserName { get; set; }

        public DateTimeOffset? UpdatedAt { get; set; }
    }
}
