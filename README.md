var data = JSON.parse(sTaskDetail);
var result="";
var ouputOptions="";
var elementsType;
var elementsTypetoValue;
var variableKor;
var lengthNum = Object.keys(data).length; 

for (var i=0;i<lengthNum;i++){
    if(JSON.stringify(data[i].output)=='true'){   
        
        var textValue = data[i].name;
        ouputOptions+=textValue+',';   
       
    }    
}

var sortData = data.sort(function(a, b) {
    var upperCaseA = a.name.toUpperCase();
    var upperCaseB = b.name.toUpperCase();
    
    if(upperCaseA > upperCaseB) return 1;
    if(upperCaseA < upperCaseB) return -1;
    if(upperCaseA === upperCaseB) return 0;
  })

for (var i=0;i<lengthNum;i++){
    if(JSON.stringify(sortData[i].input)=='true'&&JSON.stringify(sortData[i].output)=='false'){
        var description = sortData[i].description.replaceAll('\"',"'");
        elementsType ="";
        elementsTypetoValue="";
        var desValidationChk = "";
        if(JSON.stringify(sortData[i].description).indexOf("필수")!=-1){
            desValidationChk = "_REQUIRE"
        }
      
        if(sortData[i].type==='LIST'){
            if(ouputOptions.indexOf(sortData[i].name+"_output")==-1) continue;
            var listCnt= Object.keys(sortData[i].defaultValue.list).length;
            var sumOptions=""; 
            
            for(var j=0;j<listCnt;j++){  
                var textValue = sortData[i].defaultValue.list[j].string;
                sumOptions+='{"text": "'+textValue+'","value": "'+textValue+'"},';
            }

            sumOptions = sumOptions.slice(0,-1);
            elementsType = "select"; 
            elementsTypetoValue = '값을 선택하여 주세요." ,"options": ['+sumOptions+']},';
            result += '{"id" : "'+sortData[i].name+'","type": "'+elementsType+'","description" : "'+description+'",'+'"text": "'+sortData[i].name+elementsTypetoValue;
            continue;
        }
        if(sortData[i].type==='BOOLEAN'){

            elementsType = "radiobutton"; 
            elementsTypetoValue = '값을 선택하여 주세요." ,"description" : "'+description+'","options": [{"text": "True","value": "True"},{"text": "False","value": "False"}]},';
        }else{
            elementsType ="text";
            variableKor="숫자 형식의 값을 입력해주세요";
            if(sortData[i].type=="STRING"){
                variableKor="문자 형식의 값을 입력해주세요";
            }else if(sortData[i].type=="CREDENTIAL"){
                if(sortData[i].description == ""){
                    variableKor="자격증명 값을 입력해주세요";    
                }else{
                    variableKor= sortData[i].description;
                }
                
                elementsType ="password"
            }
            elementsTypetoValue = ' 을/를 입력해주세요.","hint": "'+variableKor+'","description" : "'+description+'"},';
        }
        result += '{"id" : "'+sortData[i].name+'_V_'+sortData[i].type+desValidationChk+'","type": "'+elementsType+'","text": "'+sortData[i].name+elementsTypetoValue;
    }
}
result = result.slice(0,-1);


---
form message
{
    "attachments": [{
      "title": "변수 입력하기 / 실행 할 업무에 전달할 값",
      "actions": [
         {
          "id":"registerCancle",
          "name": "approval",
          "text": "취소",
          "type": "button",
          "value": "cancle"
        },
        {
          "id":"registerVariable",
          "name": "approval",
          "text": "등록",
          "type": "button",
          "value": "deny",
          "confirm": {
            "dismiss_text": "취소",
            "ok_text": "등록",
            "title": "변수 입력하기",
            "elements": [
               {{$sResult}}
             ]
          }
        }
      ]
    }]
  }
