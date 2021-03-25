'''
  Program Limits:
    - Does not handle square roots.

'''

from math import e, pi

var = ''

def parse(text:str):
  global var
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
      if i == 'e':
        tree.append(e)
      elif i == 'pi':
        tree.append(pi)
      elif var == '':
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

def infixToPostfix(lst:list)->list:
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
          for j in range(len(stack)-1, -1,-1):
            if stack[j] in '*/^':
              output.append(stack.pop())
            else:
              break
          stack.append(i)
      elif i in '+-':
        for j in range(len(stack)-1, -1, -1):
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

def evalPostfix(pf:list, varVal):
  newpf = pf[:]
  for i in range(len(newpf)):
    if newpf[i].isdigit():
      newpf[i] = float(newpf[i])
    elif newpf[i] == var:
      newpf[i] = varVal
  stack = []
  for i in newpf:

    if str(i) in '+-*/^':
      rightVal = stack.pop()
      leftVal = stack.pop()
      if i == '+':
        stack.append(leftVal + rightVal)
      elif i == '-':
        stack.append(leftVal - rightVal)
      elif i == '*':
        stack.append(leftVal * rightVal)
      elif i == '/':
        stack.append(leftVal / rightVal)
      elif i == '^':
        stack.append(leftVal ** rightVal)
    else:
      stack.append(i)
  return stack[0]

def secant(x0, x1, func, iter=1, maxIter=None, maxErr=None):
  if maxIter==None == maxErr==None:
    return 'Error: Stopping requirements invalid'
  fnx0 = evalPostfix(func, x0)
  fnx1 = evalPostfix(func, x1)
  x2 = x1 - fnx1 * ((x1-x0)/(fnx1-fnx0))
  err = abs(x2-x1)
  print([iter, x0, x1, fnx0, fnx1, x2, err])
  if (iter != maxIter and maxIter != None) or (err > maxErr and maxErr != None):
    secant(x1, x2, func, iter+1, maxIter, maxErr)

# Activity 3 A.3
fn = 'x^6-x-1'
x0 = 1
x1 = 1.5
maxErr = 0.0001
func = infixToPostfix(parse(fn))
secant(x0, x1, func, maxErr=maxErr)

