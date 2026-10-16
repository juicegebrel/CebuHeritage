/** @type {import('tailwindcss').Config} */
module.exports = {
  // Class names used in C# data files (e.g. gradients) must be written as full strings so they are picked up here.
  content: [
    "./Components/**/*.{razor,html,cs}",
    "./Data/**/*.cs",
    "./Models/**/*.cs",
    "./Services/**/*.cs",
  ],
  theme: {
    extend: {
      colors: {
        ink: "#14213D",        // deep navy, used for text and dark sections
        sea: {
          DEFAULT: "#0E7C86",
          dark: "#0A5C64",
          light: "#D9EFF0",
        },
        sinulog: "#C2185B",    // festival magenta
        saffron: "#F4B400",    // festival yellow
        foam: "#F3F8F7",       // page background
      },
      fontFamily: {
        display: ['"Bricolage Grotesque"', "ui-sans-serif", "system-ui", "sans-serif"],
        body: ["Figtree", "ui-sans-serif", "system-ui", "sans-serif"],
      },
    },
  },
  plugins: [],
};
