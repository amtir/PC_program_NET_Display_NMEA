# Weather Station Display — Windows App (VB.NET)

A Windows desktop application that connects to an **NMEA 0183 weather station** over a serial port. It shows live **wind speed and direction, air temperature, relative humidity and barometric pressure**, plots them over time and can dump the raw data stream.

## Features

- **Serial connection** with configurable COM port settings
- **NMEA 0183 parser** with checksum validation for the station's sentences:

  | Sentence | Data |
  |----------|------|
  | `$WIMWV` | Wind speed and angle |
  | `$WIMTA` | Air temperature |
  | `$WIMTS` | Temperature (sensor) |
  | `$WIMHU` | Relative humidity |
  | `$WIMMB` | Barometric pressure |

- **Live dashboard** with the current values
- **Real-time charts** of temperature, humidity, wind angle and wind speed (MS Chart controls)
- **ASCII dump** window to inspect or save the raw NMEA stream
- Splash screen, About box and **MSI installer**

## Getting Started

**Install:** run `installer/setup.exe`, or `installer/SetupDisplayELBW.msi`.

**Build from source:**
1. Open `src/Display_ELBW_V1_3/Display_ELBW.sln` in Visual Studio.
2. Target **.NET Framework 3.5**. The chart control needs *Microsoft Chart Controls for .NET 3.5* (`System.Windows.Forms.DataVisualization`).
3. Build and run, then choose the COM port and **Connect**.

## Repository Structure

```
.
├── src/Display_ELBW_V1_3/
│   ├── Display_ELBW.sln
│   ├── Display_ELBW/          # WinForms app: Display, ParseData, frmGraphics, COM settings, …
│   └── SetupDisplayELBW/      # Visual Studio setup (installer) project
└── installer/                 # Built setup.exe / .msi
```

## Related

The [NMEA_LCD_DISPLAY](https://github.com/amtir/NMEA_LCD_DISPLAY) repo is the embedded (8051 + LCD) counterpart for the same weather station.

## Tech Stack

VB.NET · Windows Forms · .NET Framework 3.5 · MS Chart Controls · System.IO.Ports · NMEA 0183

## Author

**Akram M'Tir**, [@amtir](https://github.com/amtir) · 2010
