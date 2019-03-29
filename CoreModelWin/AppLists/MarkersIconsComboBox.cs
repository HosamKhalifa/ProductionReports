using System.Collections.Generic;
using System.Drawing;

namespace CoreModelWin.AppLists
{
    public class MarkersIconsComboBox
    {
        
        #region Members

        private static DevExpress.Utils.ImageCollection markerImageList;
       
        #endregion

        #region Properties

        #endregion

        #region Methods
        public static void RetrieveMarkerImages()
        {
            var imagesNames = new List<string>()
            {
                 "images/setup/properties_16x16.png"
                 ,"images/status/error_16x16.png"
                 ,"images/status/warning_16x16.png"
                 ,"images/support/article_16x16.png"
                 ,"images/support/suggestion_16x16.png"
                 ,"images/tasks/edittask_16x16.png"
                 ,"images/tasks/status_16x16.png"
                 ,"images/toolbox%20items/checkbox2_16x16.png"
                 ,"images/scheduling/dayview_16x16.png"
                 ,"images/scheduling/monthview_16x16.png"
                 ,"images/scheduling/switchtimescalesto_16x16.png"
                 ,"images/scheduling/weekview_16x16.png"
                 ,"images/setup/loadpagesetup_16x16.png"
                 ,"images/sort/sortgroupheader_16x16.png"
                 ,"images/spreadsheet/allowuserstoeditranges_16x16.png"
                 ,"images/spreadsheet/showdetail_16x16.png"
                 ,"images/spreadsheet/useinformula_16x16.png"
                 ,"images/math/showformulas_16x16.png"
                 ,"images/media/media_16x16.png"
                 ,"images/media/youtube_16x16.png"
                 ,"images/miscellaneous/colors_16x16.png"
                 ,"images/miscellaneous/currency_16x16.png"
                 ,"images/miscellaneous/design_16x16.png"
                 ,"images/miscellaneous/wizard_16x16.png"
                 ,"images/mode/touchmode_16x16.png"
                 ,"images/navigation/backward_16x16.png"
                 ,"images/navigation/documentmap_16x16.png"
                 ,"images/navigation/forward_16x16.png"
                 ,"images/navigation/home_16x16.png"
                 ,"images/navigation/navigationbar_16x16.png"
                 ,"images/navigation/next_16x16.png"
                 ,"images/navigation/previous_16x16.png"
                 ,"images/navigation/up_16x16.png"
                 ,"devav/actions/about_16x16.png"
                 ,"devav/actions/buy_16x16.png"
                 ,"devav/actions/delete_16x16.png"
                 ,"devav/actions/edit_16x16.png"
                 ,"devav/contacts/mail3_16x16.png"
                 ,"devav/contacts/mobilephone_16x16.png"
                 ,"devav/opportunities/hight_16x16.png"
                 ,"devav/opportunities/low_16x16.png"
                 ,"devav/opportunities/medium_16x16.png"
                 ,"devav/people/employeeaward_16x16.png"
                 ,"devav/people/employeeexcellence_16x16.png"
                 ,"devav/people/employeenotice_16x16.png"
                 ,"devav/people/employeethank_16x16.png"
                 ,"devav/people/miss_16x16.png"
                 ,"devav/people/mr_16x16.png"
                 ,"devav/people/mrs_16x16.png"
                 ,"devav/people/ms_16x16.png"
                 ,"devav/people/people_16x16.png"
                 ,"images/business%20objects/bocontact_16x16.png"
                 ,"images/business%20objects/borole_16x16.png"
                 ,"images/business%20objects/bosale_16x16.png"
                 ,"images/business%20objects/boscheduler_16x16.png"
                 
            };
            
            if (markerImageList.Images.Count == 0)
            {
                foreach (var item in imagesNames)
                {
                    Image img = DevExpress.Images.ImageResourceCache.Default.GetImage(item);
                    markerImageList.AddImage(img); 
                }

            }
        }
        public static void PopulateMarkerImageComboBox(DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox imageBox)
        {
            RetrieveMarkerImages();
            imageBox.Items.Clear();
            imageBox.SmallImages = markerImageList;
            imageBox.LargeImages = markerImageList;
            int indx = 0;
            int imgIndex = -1;
            //Add null item
            imageBox.Items.Add(new DevExpress.XtraEditors.Controls.ImageComboBoxItem("N/A", null, -1));
            foreach (var img in markerImageList.Images)
            {
                indx += 10;
                imgIndex += 1;
                DevExpress.XtraEditors.Controls.ImageComboBoxItem item =
                    new DevExpress.XtraEditors.Controls.ImageComboBoxItem($"Icon{indx}",indx, imgIndex);
                imageBox.Items.Add(item);
            }

        }
        #endregion

        #region EventHandlers

        #endregion
    }




}