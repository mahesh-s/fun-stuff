using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using HomeSurfer.Web.App_Start;
using HomeSurfer.Web.Models;

namespace HomeSurfer.Web.ViewModels
{
    public class ViewModelBase
    {
        private bool? _canEdit = null;
        private bool? _canDelete = null;

        private RoleEvaluator _evaluator =new RoleEvaluator();

        public bool CanEdit
        {
            get
            {
                if (!_canEdit.HasValue)
                {
                    _canEdit = _evaluator.CanEdit;
                }

                return _canEdit.Value;
            }
        }

        public bool CanDelete
        {
            get
            {
                if (!_canDelete.HasValue)
                {
                    _canDelete = _evaluator.CanDelete;
                }

                return _canDelete.Value;
            }
        }

        public string ImageUrlPrefix
        {
            get { return Config.ImagesUrlPrefix; }
        }
    }
}