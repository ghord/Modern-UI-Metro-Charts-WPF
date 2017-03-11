# Modern-UI-Metro-Charts-WPF
Fork of Modern UI (Metro) Charts WPF https://modernuicharts.codeplex.com/ with various bug fixes/enhancments


Bug fixes:
- You can now set 0 as starting percentage in `RadialGaugeChart`
- You can now safely set percentages to fractional values in `RadialGaugeChart`


Enhancements
- Added `RadialPieceStyle` to `RadialGaugeChart` along with additional `PercentageFontSize` and `PercentageSmallFontSize` properties on `RadialGaugePiece` to make it more customizable. Sample usage:

```xaml
<charts:RadialGaugeChart>
  <charts:RadialGaugeChart.RadialPieceStyle>
    <Style TargetType="charts:RadialGaugePiece" BasedOn="{StaticResource {x:Type charts:RadialGaugePiece}}">
      <Setter Property="ClientHeight" Value="100" />
      <Setter Property="ClientWidth" Value="100" />
      <Setter Property="PercentageFontSize" Value="18" />
      <Setter Property="PercentageSmallFontSize" Value="12" />
    </Style>
  </charts:RadialGaugeChart.RadialPieceStyle>
<charts:RadialGaugeChart>
```

- You can now customize `ItemsPanelTemplate` on `RadialGaugeChart`. Sample usage:

```xaml
<ResourceDictionary Source="pack://application:,,,/De.TorstenMandelkow.MetroChart;component/Themes/Generic.xaml"/>
```

```xaml
<charts:RadialGaugeChart> 
  <charts:RadialGaugeChart.PlotterAreaStyle>
     <Style TargetType="charts:PlotterArea" BasedOn="{StaticResource RadialGaugeChartPlotterAreaStyle}">
        <Setter Property="DataPointItemsPanel">
            <Setter.Value>
                <ItemsPanelTemplate>
                    <UniformGrid Rows="1" />
                </ItemsPanelTemplate>
            </Setter.Value>
        </Setter>
    </Style>
  </charts:RadialGaugeChart.PlotterAreaStyle>
</charts:RadialGaugeChart>
```

