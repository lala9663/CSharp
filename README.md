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
