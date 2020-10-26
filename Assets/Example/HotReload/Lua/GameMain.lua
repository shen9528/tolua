require("HotReload")

GameMain = {}

function GameMain.start()
    print("GameMain start.")
end

function GameMain.testFunc()
    local testHotReload = require("TestHotReload")
    testHotReload.testFunc()
end

GameMain.start()