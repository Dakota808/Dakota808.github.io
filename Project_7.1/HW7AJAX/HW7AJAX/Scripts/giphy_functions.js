var boringWords = ["", "the", "to", "and", "of", "that", "have", "from", "by", "save",
    "was", "has", "am", "over", "up", "down", "too", "who", "get", "always"
];

    /**
    * This fucntion is using the entire string an retuning the 
    * entire inputs length
    */
function userInput() {
    /**
    * Returns the string length of the input in the text field.
    */

    return $("#userInput").val().length;
}

/**
* This is returning the particular keywords that we are sending to 
* Giphy to as longs as they do meet with any of the words from the
* boringWords list.
* @param {any} keyWord
*/
function isKeyword(keyWord)
{
    var temp = keyWord;

    var isKeyword = true;
    for (var i = 0; i < boringWords.length; i++)
    {
        if (boringWords[i].toLowerCase() == temp.toLowerCase())
        {
            isKeyword = false;
        }
    }
    return isKeyword;
}

function displayGif(result)
{
    var giphyUrl = result.data.images.preview_git.url;

    console.log(giphyUrl);
    $("#message").append("<img width='150px;' height='150px;' src='" + giphyUrl + "'/>");

}

function insertWord(keyWord)
{

    $("#messageContainer").append(" " + "<label> " + keyWord + " </label>");
}

function getKeywordTyped()
{
    var KeyWord = "";

    var input = document.getElementById("userInput").value;

    var parsedInput = input.substr(0, input.length).replace(/[.,\/#!$%^&\*;:{}=\-_`~()]/g, "");

    if (/\S/.test(parsedInput))
    {
        keyWord = parsedInput.split(" ").pop();

    }

    return keyWord;
}
