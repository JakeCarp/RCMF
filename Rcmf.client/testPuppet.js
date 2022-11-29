const puppeteer = require("puppeteer");

// (async () => {
//   const browser = await puppeteer.launch();
//   const page = await browser.newPage();
//   await page.goto("https://kenjimmy.me");
//   await page.screenshot({ path: "example.png" });

//   await browser.close();
// })();
(async () => {
  const browser = await puppeteer.launch();
  const page = await browser.newPage();
  await page.goto("https://github.com/TriLe1122");
 await page.select('body > div.application-main > main > div.container-xl.px-3.px-md-4.px-lg-5 > div > div.Layout-sidebar > div > div.js-profile-editable-replace > div.d-flex.flex-column > div.js-profile-editable-area.d-flex.flex-column.d-md-block > div:nth-child(2) > button')
  await page.screenshot({ path: "src/assets/img/puppetier/test.png" });

  await browser.close();
})();
//156.36 x 48