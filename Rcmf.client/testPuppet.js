


"use strict";

const fs = require("fs");
const https = require("https");
const puppeteer = require("puppeteer");

/* ============================================================
  Promise-Based Download Function
============================================================ */

const download = (url, destination) =>
  new Promise((resolve, reject) => {
    const file = fs.createWriteStream(destination);

    https
      .get(url, (response) => {
        response.pipe(file);

        file.on("finish", () => {
          file.close(resolve(true));
        });
      })
      .on("error", (error) => {
        fs.unlink(destination);

        reject(error.message);
      });
  });

/* ============================================================
  Download All Images
============================================================ */

(async () => {
  const browser = await puppeteer.launch();
  const page = await browser.newPage();

  let result;

  await page.goto(
    "https://www.facebook.com/profile.php?id=100064958131113&sk=photos"
  );

  const images = await page.evaluate(() =>
    Array.from(document.images , (e) => e.href)
  );

  for (let i = 0; i < images.length; i++) {
    result = await download(
      images[i],
      `src/assets/img/puppetier/image-${i}.png`
    );

    if (result === true) {
      console.log("Success:", images[i], "has been downloaded successfully.");
    } else {
      console.log("Error:", images[i], "was not downloaded.");
      console.error(result);
    }
  }

  await browser.close();
})();
