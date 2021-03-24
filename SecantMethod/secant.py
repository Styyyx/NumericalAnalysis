class Node:
  def __init__(self, data):
    self.left = None
    self.right = None
    self.data = data

  def insert(self, data, side = None):
    if (side == None):
      if self.left == None:
        self.left = Node(data)
      elif self.right == None:
        self.right = Node(data)

def infixToPostfix(lst):
  stack = []
  output = []
  for i in lst:
    if i in '+-*/^':
      if len(stack) == 0:
        stack.append(i)
      elif stack[-1] == '(':
        stack.append(i)
      elif i == '^':
        stack.append(i)
      elif i in '*/':
        if stack[-1] in '+-':
          stack.append(i)
        else:
          for j in range(len(stack)-1,0,-1):
            if stack[j] in '*/^':
              output.append(stack.pop())
            else:
              break
          stack.append(i)
      elif i in '+-':
        for j in range(len(stack)-1, 0, -1):
          if stack[j] in '+-*/^':
            output.append(stack.pop())
          else:
            break
        stack.append(i)
    elif i == '(':
      stack.append(i)
    elif i == ')':
      for j in range(len(stack)-1, 0, -1):
        if stack[j] == '(':
          stack.pop()
          break
        else:
          output.append(stack.pop())
    else:
      output.append(i)

  while len(stack) != 0:
    output.append(stack.pop())
  return output

def parse(text:str):
  var = ''
  groupCount=0
  tree = []
  text.replace(' ', '')
  for i in text:
    if len(tree) == 0:
      tree.append(i)
    elif i.isdigit():
      if tree[-1].isdigit():
        tree[-1] += i
      else:
        tree.append(i)
    elif i in '+-*/^':
      tree.append(i)
    elif i in '()':
      if i == '(' and tree[-1].isdigit():
          tree.append('*')
          tree.append(i)
          groupCount += 1
      else:
          if groupCount > 0 and tree[-1] not in '+-*/^':
            tree.append(i)
            groupCount -= 1
    elif i.isalpha():
      if var == '':
        var = i
        if tree[-1].isdigit():
          tree.append('*')
        tree.append(i)
      elif i == var:
        if tree[-1].isdigit():
          tree.append('*')
        tree.append(i)
      else:
        print('Error: Cannot process more than one variable')
  return tree

print(''.join(i for i in infixToPostfix(parse('5x^2 + 4(1-x)'))))