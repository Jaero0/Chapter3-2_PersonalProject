# Chapter3-2_PersonalProject
 
* 개발 : 정재호

# 구현 과제 

* 스파르타 던전 V. Unity

# 기능구현 목록
1. 메인화면구성
2. Ststus 보기
3. Inventory 보기

## 기능구현방법
1. 메인화면구성
1-1. UI로 해결하였다. Layout Group을 사용하여 정밀정렬하였다.
2. Ststus 보기
2-1. 원래는 전부 UI로 해결하였으나, 의미가 없을것같아서 플레이어 데이터를 만들어 접근했다.
3. Inventory 보기
3-1.아이템과 슬롯은 모두 데이터를 이용했고, 게임 시작시에 변경될수 있도록 직접 동적으로 Instanciate해주었다. 하지만 장착하는 과정에 버그가 있다. 
3-2. 버그. 
동적으로 invenslot을 생성해주었다. 하지만 장착을 할거냐는 팝업창에서는 미리 만들어져있던 invenslot프리팹에 접근해서 Getchild를 해오기에, 디버깅을 하면 자식이 null로 찍혔다.
아직은 해결가능한 영역이 아니라서, 후에 UI를 이벤트를 이용해 직접 컨트롤하지않고 동적으로 컨트롤 할 수 있는 방법을 연구해봐야겠다.

### 추가 기능
간단한 UI로 해결가능했지만, 뭔가 심심한것같아서 Ststus와 Inventory창을 켜고 끌때, dotween을 이용하여 애니메이션 효과를 주었고, 그에 맞춰 플레이어 애니메이션도 움직이게 해보았다.

조금은 더 이뻐보이는 효과!!
