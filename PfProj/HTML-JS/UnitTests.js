const { Builder, By } = require('selenium-webDriver');
const assert = require("assert");

async function APITest() {
    let driver = await new Builder().forBrowser("chrome").build();
    try {
        await driver.get("file:///C:/Users/colto/Documents/GitHub/P2Team2/P2Team2/PfProj/HTML-JS/character.html");
        await driver.FindElement(By.Name("textarea")).SendKeys("Selenium_Name");
        await driver.findElement(By.id("radio1")).click()
        await driver.findElement(By.id("submitbutton")).click();
        await driver.manage().timeouts().implicitlyWait(Duration.ofSeconds(2));

        const success = await driver.findElement(By.id("success")).getText();
        
        assert.strictEqual(success, "Success!");
    }
    finally {
        await driver.quit();
    }
}

