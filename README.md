[![Open in Visual Studio Code](https://classroom.github.com/assets/open-in-vscode-2e0aaae1b6195c2367325f4f02e2d04e9abb55f0b24a779b69b11b9e10269abc.svg)](https://classroom.github.com/online_ide?assignment_repo_id=22157907&assignment_repo_type=AssignmentRepo)


**맵탈출게임**

1. 무엇을 만드는데?
	- 플레이어가 시작점에서 도착점까지 이동하면 되는 게임
2. 유저가 보게될 결과물
	 - 시작지점에 서 있는 플레이어
	 - 도착지점
	 - 벽으로 쌓인 맵 (그러나 시작지점과 도착지점이 이어져있어야함.)
3. 최소 기능
	 - 플레이어, 도착점, 벽
	 - 이동 가능
 4. 우선 순위
     - 맵
     - 플레이어 
     - 도착점
 5.  추가 기능
    - 벽에 부딪히면 HP 감소
    - 전부 감소되면 게임종료
    - 맵 3단계 까지 만들기
    - 맵 구성 시 랜덤 생성
    - 시작부터 종료까지 시간 기록 재기
    
주어진 소스 활용
- 플레이어 -> 시작점 고정위치로 변경
- 아이템 -> 하나만 존재하여 도착지점으로 변경
- 맵 -> 오브젝트 벽 생성 -> 벽을 지뢰 폭탄 등으로 변경
---------------------------------------
- HP -> 벽으로 이동 시 HP 감소 -> 목숨 1 로 변경?
- HP -> HP 0일 시 게임종료