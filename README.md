Adaptive Cards

{
  "$schema": "http://adaptivecards.io/schemas/adaptive-card.json",
  "type": "AdaptiveCard",
  "version": "1.3",
  "body": [
    {
      "type": "TextBlock",
      "text": "maple 값을 입력해주세요",
      "wrap": true
    },
    {
      "type": "Input.Text",
      "id": "maple",
      "placeholder": "maple 값을 입력"
    },
    {
      "type": "TextBlock",
      "text": "lol 값을 입력해주세요",
      "wrap": true
    },
    {
      "type": "Input.Text",
      "id": "lol",
      "placeholder": "lol 값을 입력"
    },
    {
      "type": "TextBlock",
      "text": "star 값을 입력해주세요",
      "wrap": true
    },
    {
      "type": "Input.Text",
      "id": "star",
      "placeholder": "star 값을 입력"
    }
  ],
  "actions": [
    {
      "type": "Action.Submit",
      "title": "Submit"
    }
  ]
}

나는 이걸 
input 변수  {"maple":"","lol":"","star":""}
이 길이만큼 사용하고싶은건데 이 input변수를 사용할 수 있어 여기 카드에?




2번 질문

var parseData = JSON.parse(sortingInput);

function createAdaptiveCard(parseData) {
    var adaptiveCard = {
        "$schema": "http://adaptivecards.io/schemas/adaptive-card.json",
        "type": "AdaptiveCard",
        "version": "1.3",
        "body": [],
        "actions": []
    };
    
    var hasInput = false;
    
    if(parseData === 0){
        adaptiveCard.body.push({
            "type": "TextBlock",
            "text": "입력할 값이 필요 없습니다.",
            "wrap": true,
            "color": "attention"
        });
    } else {
        for (var i = 0; i < parseData.length; i++) {
        var name = parseData[i];
        adaptiveCard.body.push({
            "type": "TextBlock",
            "text": name + " 값을 입력해주세요",
            "wrap": true
        });

        adaptiveCard.body.push({
            "type": "Input.Text",
            "id": name,
            "placeholder": name + " 값을 입력"
        });
    }
    
    adaptiveCard.actions.push({
        "type": "Action.Submit",
        "title": "Submit"
    });
    
    }
    

    return adaptiveCard;
}

// Adaptive Card JSON 생성
var card = createAdaptiveCard(parseData);
