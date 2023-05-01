# Inkies
Inkies is an underwater action game featuring design and art by my school-aged cousin.

## Gameplay
Inkies supports multiple input mechanisms:
- Use the arrow or WASD keys to move. Press space to ink nasties.
- Use the virtual d-pad to move and ink nasties.
- Click and drag to move and ink nasties.

Avoid nasties and get a high score.

![Inkies gameplay](https://github.com/mklewandowski/inkies/blob/main/Assets/Images/inkies-gameplay.gif?raw=true)

## Supported Platforms
Inkies is designed for use on multiple platforms including:
- iOS
- Android
- Web
- Mac and PC standalone builds

## Running Locally
Use the following steps to run locally:
1. Clone this repo
2. Open repo folder using Unity 2021.3.23f1
3. Install Text Mesh Pro

## Building the Project

### WebGL Build
For embedding within itch.io and other web pages, we use the `better-minimal-webgl-template` seen here:
https://seansleblanc.itch.io/better-minimal-webgl-template

Setup of the `better-minimal-webgl-template` is as follows:
1. Download and unzip the template.
2. Copy the `WebGLTemplates` folder into the `Assets` folder.
3. File -> Build Settings... -> WebGL -> Player Settings... -> Select the "BetterMinimal" template.
4. Enter color in the "Background" field.
5. Enter "false" in the "Scale to fit" field to disable scaling.
6. Enter "true" in the "Optimize for pixel art" field to use CSS more appropriate for pixel art.

### Running a Unity WebGL Build
1. Install the "Live Server" VS Code extension.
2. Open the WebGL build output directory with VS Code.
3. Right-click `index.html`, and select "Open with Live Server".

## Development Tools
- Created using Unity
- Code edited using Visual Studio Code
- Sounds created using [Bfxr](https://www.bfxr.net/)
- Audio edited using [Audacity](https://www.audacityteam.org/)
- 2D images created and edited using [Paint.NET](https://www.getpaint.net/)

## Credits
Mobile and mouse dragging adapted from these tutorials:
- https://www.youtube.com/watch?v=yalbvB84kCg
- https://www.youtube.com/watch?v=ST7BAqV-1ow
