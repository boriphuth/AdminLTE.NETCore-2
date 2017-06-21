using System;
using System.Collections.Generic;
using System.Text;

namespace APP.Core.Entities
{
    /// <summary>
    /// 数据库实体的基类,要审核的实体都要继承该类
    /// </summary>
   public class FullAuditedEntity
    {
        public int Id  { get; set; }
        public DateTime CreationTime { get; set; }
        public int? CreatorUserId { get; set; }
        public int? LastModifierUserId { get; set; }
        public DateTime? LastModificationTime { get; set; }
        public bool IsDeleted { get; set; }
        public int? DeleterUserId { get; set; }
        public DateTime? DeletionTime { get; set; }
    }
}
