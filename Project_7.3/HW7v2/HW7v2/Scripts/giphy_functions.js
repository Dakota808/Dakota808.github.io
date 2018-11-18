var boringWords = ["", "the", "to", "and", "of", "that", "have", "from", "by", "save","was", "has", "am", "over", "up", "down", "too", "who", "get", "always", "his", "hers", "by", "from", "they", "so", "up", "out", "if", "about", "who", "get", "which", "go", "me", "public", "are",
    "make", "can", "like", "time", "no", "just", "know", "take", "people", "into", "year", "your", "good", "some", "could", "always", "went",
    "them", "see", "other", "than", "then", "now", "look", "only", "come", "its", "it's", "over", "think", "also", "back", "really", "store",
    "after", "use", "two", "how", "our", "work", "first", "well", "way", "even", "new", "want", "because", "any", "these", "give", "every",
    "day", "most", "us", "my", "mine", "yours", "they're", "I'm", "going", "took", "huge", "big", "large", "very", "am", "let's", "had",
    "try", "wicked", "pretty", "is", "please", "was", "name", "named", "stay", "away", "any", "anymore", "we're", "brought", "does", "did"
];


function userInput() {


    return $("#userInput").val().length;
}



function isKeyword(keyWord)
{
    var temp = keyWord;

    var isKeyword = true;
    for (var i = 0; i < boringWords.length; i++)
    {
        if (boringWords[i].toLowerCase() === temp.toLowerCase())
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

function actionChoice(keyWord)
{
    if (isKeyword(keyWord))
    {
        $.ajax(
            {
                datatype: "json",
                url: "/Request/GiphyTranslator?=",
                data: { "keyWord": keyWord },
                success: insertWord
            });

    }
    else
    {
        insertWord(keyWord);

    }

    function main()
    {
        $("#userInput").focus();

        $("#userInput").keypress(function ()
        {
            
            if ($("#userInput").val().length > 0 && event.which === 32)
            {
                var keyWord = getKeywordTyped();

                actionChoice(keyWord);

                $("#userInput").focus();
            }

        });


    }
}

$(document).ready(main);