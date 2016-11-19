# Project Name - V.Tabs

Sample MvvmCross WPF application with a tabs presenter. A tab bar is defined in the `HomeView` allowing one to switch between all three tabs. `TabOne` has a button to show a full screen view, replacing the tab view with a full screen view.


## Usage

Applicaiton is made up of four `Views`:
* Home - Main screen that holds the tab bar and where tabs are shown
* TabOne - Sample tab that also includes a button to show a full screen view
* TabTwo and TabThree - Extra tabs to fill out the application
* DetailFullScreen - A full screen view that replaces the `HomeView`, creating a 'modal' screen.  Button allows one to close this and return to the `HomeView`

## TabPresenter
`TabPresenter.cs` in `V.Tabs.Wpf\Utilitiles` manages swapping and replacing `Views` based on user input.  By decorating a View's `xaml.cs` class definition with a `Region` attribute will define where that `View` is shown.

i.e. From `TabOneView.xaml.cs`
```
[Region(Region.Tab)]
public partial class TabOneView
{
```
Tells the `TabPresenter` this region is a tab and to replace the currently shown tab in the `HomeView`.

Contrastly, `DetailFullScreenView.xaml.cs` is decorated with 
```
[Region(Region.FullScreen)]
public partial class DetailFullScreenView
{
``` 
Telling the `TabPresenter` to replace the entire `HomeView` with the contents of `DetailFullScreenView`.  Once the user closes `DetailFullScreenView` the `HomeView` with the tabs will again be shown the user.  `DetailFullScreenView` is stacked on top of `HomeView` to take over the whole screen.
## History

11.9.2016 Initial commit

