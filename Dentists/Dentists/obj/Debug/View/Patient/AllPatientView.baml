   M S B A M L   `   `   `  ����C  ?Dentists, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:Dentists.View.PatientDentists.View.Patient  5   P   *    $Dentists.View.Patient.AllPatientView   5      a ]DevExpress.Xpf.Grid.v14.2, Version=14.2.3.0, Culture=neutral, PublicKeyToken=b88d1754d700e49af bDevExpress.Xpf.Grid.v14.2.Core, Version=14.2.3.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a>dxg2http://schemas.devexpress.com/winfx/2008/xaml/grid   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      a ]DevExpress.Xpf.Core.v14.2, Version=14.2.3.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a] YDevExpress.Mvvm.v14.2, Version=14.2.3.0, Culture=neutral, PublicKeyToken=b88d1754d700e49aAdxmvvm2http://schemas.devexpress.com/winfx/2008/xaml/mvvm   5      6
ViewModels#clr-namespace:Dentists.View.Patient   6P     � DataContext  5	      /   )Dentists.View.Patient.AllPatientViewModel  5
   
   .��5      � .+�5   
   %  DevExpress.Xpf.Grid.GridControl  )  #DevExpress.Xpf.Grid.DataControlBase   ItemsSource 6   ��  �� Path$ AllPatients�   TotalSummary 5      )  #DevExpress.Xpf.Grid.GridSummaryItem  5      )  #DevExpress.Xpf.Grid.SummaryItemBase   SummaryType$	 Sum=�6&      View 5      #  DevExpress.Xpf.Grid.TableView  5      -   5          Name$ TVAllPatients��5       &   DevExpress.Xpf.Grid.DataViewBase   CellTemplate 5      �� 5      .R�5      � .+�5   "   �� �� 6-   $
�ages��61   6@   �� 5   "   ��6*   �� *Age+5      5      5         Columns 5      $  DevExpress.Xpf.Grid.GridColumn  5      $	  DevExpress.Xpf.Grid.BaseColumn	 	  Header)
  #DevExpress.Xpf.Core.ObjectConverter$	 姓名
 6!   '
 	   HorizontalHeaderContentAlignment$
 Center=�6-   $  DevExpress.Xpf.Grid.ColumnBase   	FieldName$
 Name��6W   6j     5      $	 性别
 6!   $
 Center=�6-   $ Gender��6W   6l     5       $	 年龄
 6!   $
 Center=�6-   $	 Age��6W   6i     5!      $	 家庭电话
 6!   $
 Center=�6/   $ HousePhoneNumber��6Y   6x     5"      $	 手机
 6!   $
 Center=�6-   $ CellPhoneNumber��6W   6u     5#      $	 住址
 6!   $
 Center=�6-   $ Address��6W   6m     5$      $	 诊断结果
 6!   $
 Center=�6/   $ 	Diagnosis��6Y   6q     5%      $	 诊断日期
 6!   $
 Center=�6/   $ DiagnosisDate��6Y   6u     5&      $	 医师
 6!   $
 Center=�6-   $ Doctor��6W   6l   5(      5)      5*      